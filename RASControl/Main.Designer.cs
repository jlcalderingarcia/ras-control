namespace RASControl
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startMinimizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectedCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.hide1TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.automaticallyOpenTheConnectionWidgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.notifyCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.hideToolStripMenuItem.Text = "&Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hide1TSMI_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(96, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoStartToolStripMenuItem,
            this.startMinimizedToolStripMenuItem,
            this.toolStripMenuItem3,
            this.automaticallyOpenTheConnectionWidgetToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // autoStartToolStripMenuItem
            // 
            this.autoStartToolStripMenuItem.Name = "autoStartToolStripMenuItem";
            this.autoStartToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.autoStartToolStripMenuItem.Text = "&Auto start";
            this.autoStartToolStripMenuItem.Click += new System.EventHandler(this.autoStartToolStripMenuItem_Click);
            // 
            // startMinimizedToolStripMenuItem
            // 
            this.startMinimizedToolStripMenuItem.Name = "startMinimizedToolStripMenuItem";
            this.startMinimizedToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.startMinimizedToolStripMenuItem.Text = "Start minimized";
            this.startMinimizedToolStripMenuItem.Click += new System.EventHandler(this.startMinimizedToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCol,
            this.UsedTimeCol,
            this.RemainingTimeCol,
            this.ConnectedCol});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(467, 273);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Name";
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            // 
            // UsedTimeCol
            // 
            this.UsedTimeCol.HeaderText = "Used Time";
            this.UsedTimeCol.Name = "UsedTimeCol";
            this.UsedTimeCol.ReadOnly = true;
            // 
            // RemainingTimeCol
            // 
            this.RemainingTimeCol.HeaderText = "Remaining Time";
            this.RemainingTimeCol.Name = "RemainingTimeCol";
            this.RemainingTimeCol.ReadOnly = true;
            // 
            // ConnectedCol
            // 
            this.ConnectedCol.HeaderText = "Connected";
            this.ConnectedCol.Name = "ConnectedCol";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "The app is running on background";
            this.notifyIcon.BalloonTipTitle = "Connection Registry";
            this.notifyIcon.ContextMenuStrip = this.notifyCMS;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "My Connection Registry App";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.showTSMI_Click);
            // 
            // notifyCMS
            // 
            this.notifyCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTSMI,
            this.hide1TSMI,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem1});
            this.notifyCMS.Name = "notifyCMS";
            this.notifyCMS.Size = new System.Drawing.Size(104, 76);
            this.notifyCMS.Opening += new System.ComponentModel.CancelEventHandler(this.notifyCMS_Opening);
            // 
            // showTSMI
            // 
            this.showTSMI.Name = "showTSMI";
            this.showTSMI.Size = new System.Drawing.Size(103, 22);
            this.showTSMI.Text = "&Show";
            this.showTSMI.Click += new System.EventHandler(this.showTSMI_Click);
            // 
            // hide1TSMI
            // 
            this.hide1TSMI.Name = "hide1TSMI";
            this.hide1TSMI.Size = new System.Drawing.Size(103, 22);
            this.hide1TSMI.Text = "&Hide";
            this.hide1TSMI.Click += new System.EventHandler(this.hide1TSMI_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem1.Text = "&Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(297, 6);
            // 
            // automaticallyOpenTheConnectionWidgetToolStripMenuItem
            // 
            this.automaticallyOpenTheConnectionWidgetToolStripMenuItem.Name = "automaticallyOpenTheConnectionWidgetToolStripMenuItem";
            this.automaticallyOpenTheConnectionWidgetToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.automaticallyOpenTheConnectionWidgetToolStripMenuItem.Text = "Automatically open the connection widget";
            this.automaticallyOpenTheConnectionWidgetToolStripMenuItem.Click += new System.EventHandler(this.automaticallyOpenTheConnectionWidgetToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 312);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Connexions Registry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.notifyCMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoStartToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingTimeCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ConnectedCol;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyCMS;
        private System.Windows.Forms.ToolStripMenuItem showTSMI;
        private System.Windows.Forms.ToolStripMenuItem hide1TSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem startMinimizedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem automaticallyOpenTheConnectionWidgetToolStripMenuItem;
    }
}

