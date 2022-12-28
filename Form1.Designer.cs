namespace DenonSpeakerSelect
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.speakersAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speakersBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speakersABToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.menuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speakersAToolStripMenuItem,
            this.speakersBToolStripMenuItem,
            this.speakersABToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(181, 120);
            // 
            // speakersAToolStripMenuItem
            // 
            this.speakersAToolStripMenuItem.Name = "speakersAToolStripMenuItem";
            this.speakersAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speakersAToolStripMenuItem.Text = "Speakers A";
            this.speakersAToolStripMenuItem.Click += new System.EventHandler(this.speakersAToolStripMenuItem_Click);
            // 
            // speakersBToolStripMenuItem
            // 
            this.speakersBToolStripMenuItem.Name = "speakersBToolStripMenuItem";
            this.speakersBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speakersBToolStripMenuItem.Text = "Speakers B";
            this.speakersBToolStripMenuItem.Click += new System.EventHandler(this.speakersBToolStripMenuItem_Click);
            // 
            // speakersABToolStripMenuItem
            // 
            this.speakersABToolStripMenuItem.Name = "speakersABToolStripMenuItem";
            this.speakersABToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speakersABToolStripMenuItem.Text = "Speakers A+B";
            this.speakersABToolStripMenuItem.Click += new System.EventHandler(this.speakersABToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon notifyIcon1;
        private ContextMenuStrip menuStrip1;
        private ToolStripMenuItem speakersAToolStripMenuItem;
        private ToolStripMenuItem speakersBToolStripMenuItem;
        private ToolStripMenuItem speakersABToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}