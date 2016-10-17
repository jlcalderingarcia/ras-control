using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotRas;

namespace RASControl
{
    public partial class ConnectionInfo : Form
    {
        private RasConnection Connection { get; set; }

        public ConnectionInfo(string entryName)
        {
            InitializeComponent();

            EntryName = entryName;
            nameL.Text = entryName;
            UpdateMenus();
            updateDataT.Enabled = true;
        }

        public string EntryName { get; set; }

        public ConnectionInfo Position(int index)
        {
            var stackSize = Screen.PrimaryScreen.WorkingArea.Height/(this.Height + 5);
            Top = Screen.PrimaryScreen.WorkingArea.Height - (this.Height + 5)*(index%stackSize + 1);
            Left = Screen.PrimaryScreen.WorkingArea.Width - (this.Width + 5)*(index/stackSize + 1);

            return this;
        }

        private void updateDataT_Tick(object sender, EventArgs e)
        {
            Connection = RasConnection.GetActiveConnections().FirstOrDefault(x => x.EntryName == EntryName);
            if (Connection != null)
            {
                try
                {
                    var statistics = Connection.GetConnectionStatistics();
                    timeL.Text = statistics.ConnectionDuration.ToString("g").Split(',')[0];
                    speedL.Text = $"{String.Format("{0:F1}", statistics.LinkSpeed/1024.0)}Kbits";
                    downL.Text =
                        $"{(int) statistics.BytesReceived/(1024*1024)}m {(int) statistics.BytesReceived/1024%1024}k";
                    upL.Text =
                        $"{(int) statistics.BytesTransmitted/(1024*1024)}m {(int) statistics.BytesTransmitted/1024%1024}k";
                }
                catch (Exception ex)
                {
                }

                UpdateMenus();
            }
        }

        private void UpdateMenus()
        {
            var updated = false;
            if (Connection != null)
            {
                try
                {
                    var status = Connection.GetConnectionStatus();
                    connectTSMI.Visible = status.ConnectionState == RasConnectionState.Disconnected;
                    disconnectTSMI.Visible = status.ConnectionState == RasConnectionState.Connected;
                    updated = true;
                }
                catch (Exception ex) { }
            }
            if(!updated)
            {
                connectTSMI.Visible = true;
                disconnectTSMI.Visible = false;
            }
        }

        private void disconnectTSMI_Click(object sender, EventArgs e)
        {
            Connection.HangUp();
            Close();
        }

        private void connectTSMI_Click(object sender, EventArgs e)
        {
            new RasDialDialog()
            {
                EntryName = EntryName,
                PhoneBookPath = RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.User)
            }.ShowDialog();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
