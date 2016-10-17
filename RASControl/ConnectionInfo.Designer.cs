namespace RASControl
{
    partial class ConnectionInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionInfo));
            this.updateDataT = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timeL = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.speedL = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.downL = new System.Windows.Forms.Label();
            this.upL = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.nameL = new System.Windows.Forms.Label();
            this.mainCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.connectTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.mainCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateDataT
            // 
            this.updateDataT.Interval = 200;
            this.updateDataT.Tick += new System.EventHandler(this.updateDataT_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timeL
            // 
            this.timeL.AutoSize = true;
            this.timeL.BackColor = System.Drawing.Color.Transparent;
            this.timeL.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.timeL.Location = new System.Drawing.Point(33, 45);
            this.timeL.Name = "timeL";
            this.timeL.Size = new System.Drawing.Size(49, 13);
            this.timeL.TabIndex = 1;
            this.timeL.Text = "00:00:00";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(105, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // speedL
            // 
            this.speedL.AutoSize = true;
            this.speedL.BackColor = System.Drawing.Color.Transparent;
            this.speedL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.speedL.Location = new System.Drawing.Point(136, 45);
            this.speedL.Name = "speedL";
            this.speedL.Size = new System.Drawing.Size(20, 13);
            this.speedL.TabIndex = 3;
            this.speedL.Text = "0K";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(3, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // downL
            // 
            this.downL.AutoSize = true;
            this.downL.BackColor = System.Drawing.Color.Transparent;
            this.downL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.downL.Location = new System.Drawing.Point(33, 75);
            this.downL.Name = "downL";
            this.downL.Size = new System.Drawing.Size(36, 13);
            this.downL.TabIndex = 5;
            this.downL.Text = "0m 0k";
            // 
            // upL
            // 
            this.upL.AutoSize = true;
            this.upL.BackColor = System.Drawing.Color.Transparent;
            this.upL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.upL.Location = new System.Drawing.Point(135, 75);
            this.upL.Name = "upL";
            this.upL.Size = new System.Drawing.Size(36, 13);
            this.upL.TabIndex = 7;
            this.upL.Text = "0m 0k";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(105, 69);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // nameL
            // 
            this.nameL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameL.BackColor = System.Drawing.Color.Transparent;
            this.nameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameL.Location = new System.Drawing.Point(12, 9);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(176, 24);
            this.nameL.TabIndex = 8;
            this.nameL.Text = "Connection Name";
            this.nameL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainCMS
            // 
            this.mainCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectTSMI,
            this.disconnectTSMI,
            this.toolStripMenuItem1,
            this.hideToolStripMenuItem});
            this.mainCMS.Name = "mainCMS";
            this.mainCMS.Size = new System.Drawing.Size(134, 76);
            // 
            // connectTSMI
            // 
            this.connectTSMI.Name = "connectTSMI";
            this.connectTSMI.Size = new System.Drawing.Size(133, 22);
            this.connectTSMI.Text = "&Connect";
            this.connectTSMI.Click += new System.EventHandler(this.connectTSMI_Click);
            // 
            // disconnectTSMI
            // 
            this.disconnectTSMI.Name = "disconnectTSMI";
            this.disconnectTSMI.Size = new System.Drawing.Size(133, 22);
            this.disconnectTSMI.Text = "&Disconnect";
            this.disconnectTSMI.Click += new System.EventHandler(this.disconnectTSMI_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 6);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.hideToolStripMenuItem.Text = "&Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // ConnectionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.ContextMenuStrip = this.mainCMS;
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.upL);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.downL);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.speedL);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.timeL);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionInfo";
            this.Opacity = 0.75D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Connection Info";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.mainCMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer updateDataT;
        private System.Windows.Forms.Label timeL;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label speedL;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label downL;
        private System.Windows.Forms.Label upL;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.ContextMenuStrip mainCMS;
        private System.Windows.Forms.ToolStripMenuItem connectTSMI;
        private System.Windows.Forms.ToolStripMenuItem disconnectTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
    }
}