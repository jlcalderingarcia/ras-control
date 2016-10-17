using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotRas;
using Microsoft.Win32;
using RASControl.Model;
using RASControl.Model.RAS;

namespace RASControl
{
    public partial class Main : Form
    {
        private ProgramData data = ProgramData.Load();
        RasConnectionWatcher watcher = new RasConnectionWatcher();
        Dictionary<string, ConnectionInfo> connectionsOpened = new Dictionary<string, ConnectionInfo>(); 

        public Main()
        {
            InitializeComponent();

            watcher.Connected += new EventHandler<RasConnectionEventArgs>(this.watcher_Connected);
            watcher.Disconnected += new EventHandler<RasConnectionEventArgs>(this.watcher_Disconnected);
            watcher.EnableRaisingEvents = true;

            autoStartToolStripMenuItem.Checked = data.AutoStart;
            RegisterInStartup(data.AutoStart);

            if (data.StartMinimized)
                Hide();
            else
                Show();
            ShowInTaskbar = !data.StartMinimized;
            WindowState = data.StartMinimized ? FormWindowState.Minimized : FormWindowState.Normal;
            Visible = !data.StartMinimized;
            startMinimizedToolStripMenuItem.Checked = data.StartMinimized;


            automaticallyOpenTheConnectionWidgetToolStripMenuItem.Checked = data.OpenConnectionWidgetAutomatically;
        }

        Dictionary<string, ConnectionLog> connectionLogs = new Dictionary<string, ConnectionLog>(); 

        private void watcher_Connected(object sender, RasConnectionEventArgs e)
        {
            // A connection has successfully connected.
            if (!connectionLogs.ContainsKey(e.Connection.EntryName))
                connectionLogs.Add(e.Connection.EntryName, new ConnectionLog()
                {
                    Name = e.Connection.EntryName,
                    Start = DateTime.Now
                });

            if (data.OpenConnectionWidgetAutomatically)
                OpenConnectionInfo(e.Connection.EntryName);

            for(var i = 0; i < dataGridView1.RowCount; i++)
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == e.Connection.EntryName)
                    ((DataGridViewCheckBoxCell) dataGridView1.Rows[i].Cells[3]).Value = true;
                
        }
        private void watcher_Disconnected(object sender, RasConnectionEventArgs e)
        {
            // A connection has disconnected successfully.
            if (connectionLogs.ContainsKey(e.Connection.EntryName))
            {
                connectionLogs[e.Connection.EntryName].End = DateTime.Now;
                data.Logs.Add(connectionLogs[e.Connection.EntryName]);
                connectionLogs.Remove(e.Connection.EntryName);
            }

            for (var i = 0; i < dataGridView1.RowCount; i++)
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == e.Connection.EntryName)
                {
                    //Update the row info
                    ((DataGridViewCheckBoxCell) dataGridView1.Rows[i].Cells[3]).Value = false;
                    var used = data.Logs.Where(x => x.Name == e.Connection.EntryName).Select(x => x.End - x.Start).ToList();
                    dataGridView1.Rows[i].Cells[1].Value = used.Any() ? used.Aggregate((x, y) => x + y).ToString("g").Split(',')[0] : "00:00:00";
                }

            //Close the widget
            if(connectionsOpened.ContainsKey(e.Connection.EntryName))
                connectionsOpened[e.Connection.EntryName].Close();
        }

        private void OpenConnectionInfo(string name)
        {
            if (connectionsOpened.ContainsKey(name))
                return;
            var info = new ConnectionInfo(name);
            info.Position(connectionsOpened.Keys.Count);
            info.Show();
            info.Closed += Info_Closed;
            connectionsOpened.Add(name, info);
        }

        private void Info_Closed(object sender, EventArgs e)
        {
            var widget = (ConnectionInfo) sender;
            if (connectionsOpened.ContainsKey(widget.EntryName))
                connectionsOpened.Remove(widget.EntryName);
            var count = 0;
            foreach (var c in connectionsOpened)
            {
                c.Value.Position(count);
                count++;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RasPhoneBook pb = new RasPhoneBook();
            pb.Open(RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.User));
            pb.EnableFileWatcher = true;
            pb.Changed += Pb_Changed;
            Pb_Changed(pb, null);

            foreach (var connection in RasConnection.GetActiveConnections())
            {
                var info = new ConnectionInfo(connection.EntryName);
                info.Position(connectionLogs.Keys.Count);
                info.Show();
                connectionLogs.Add(connection.EntryName, new ConnectionLog()
                {
                    Name = connection.EntryName,
                    Start = DateTime.Now
                });
            }
        }

        private void Pb_Changed(object sender, EventArgs e)
        {
            var pb = (RasPhoneBook) sender;

            dataGridView1.Rows.Clear();
            foreach (var item in pb.Entries)
            {
                var row = new DataGridViewRow();

                var used = data.Logs.Where(x => x.Name == item.Name).Select(x => x.End - x.Start).ToList();

                row.Cells.Add(new DataGridViewTextBoxCell() {Value = item.Name});
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = used.Any() ? used.Aggregate((x,y) => x + y).ToString("g").Split(',')[0] : "00:00:00" });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = "00:00:00" });
                row.Cells.Add(new DataGridViewCheckBoxCell() { Value = false });

                dataGridView1.Rows.Add(row);
            }
        }

        private void autoStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem) sender;

            item.Checked = !item.Checked;
            data.AutoStart = item.Checked;

            RegisterInStartup(data.AutoStart);
        }

        private void notifyCMS_Opening(object sender, CancelEventArgs e)
        {
            showTSMI.Visible = !Visible;
            hide1TSMI.Visible = Visible;
        }

        private void showTSMI_Click(object sender, EventArgs e)
        {
            this.Show();
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void hide1TSMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowInTaskbar = false;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Do you really want to exit this app?", "Closing app", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                data.Save();
                Application.Exit();
            }
        }

        private void RegisterInStartup(bool isChecked)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (isChecked)
                registryKey.SetValue("ApplicationName", Application.ExecutablePath);
            else if(registryKey.GetValueNames().Contains("ApplicationName"))
                registryKey.DeleteValue("ApplicationName");
        }

        private void startMinimizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;

            item.Checked = !item.Checked;
            data.StartMinimized = item.Checked;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //Close and hide the app
                this.ShowInTaskbar = false;
                this.Visible = false;
                this.Hide();

                //Show a tooltip noticing the user
                notifyIcon.BalloonTipTitle = "Application minimized";
                notifyIcon.BalloonTipText = "The application has being minimizaed but it's still running in the background";
                notifyIcon.ShowBalloonTip(3000);

                //Cancel the event default behavior
                e.Cancel = true;
            }
        }

        private void automaticallyOpenTheConnectionWidgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.OpenConnectionWidgetAutomatically = !data.OpenConnectionWidgetAutomatically;
            automaticallyOpenTheConnectionWidgetToolStripMenuItem.Checked = data.OpenConnectionWidgetAutomatically;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var connectionName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if(connectionsOpened.ContainsKey(connectionName))
                connectionsOpened[connectionName].Close();
            else
                OpenConnectionInfo(connectionName);
        }
    }
}
 