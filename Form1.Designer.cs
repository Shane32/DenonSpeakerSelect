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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            notifyIcon1 = new NotifyIcon(components);
            menuStrip1 = new ContextMenuStrip(components);
            speakersAToolStripMenuItem = new ToolStripMenuItem();
            speakersBToolStripMenuItem = new ToolStripMenuItem();
            speakersABToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = menuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Denon Speaker Select";
            notifyIcon1.Visible = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { speakersAToolStripMenuItem, speakersBToolStripMenuItem, speakersABToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(181, 120);
            // 
            // speakersAToolStripMenuItem
            // 
            speakersAToolStripMenuItem.Name = "speakersAToolStripMenuItem";
            speakersAToolStripMenuItem.Size = new Size(180, 22);
            speakersAToolStripMenuItem.Text = "Speakers A";
            speakersAToolStripMenuItem.Click += speakersAToolStripMenuItem_Click;
            // 
            // speakersBToolStripMenuItem
            // 
            speakersBToolStripMenuItem.Name = "speakersBToolStripMenuItem";
            speakersBToolStripMenuItem.Size = new Size(180, 22);
            speakersBToolStripMenuItem.Text = "Speakers B";
            speakersBToolStripMenuItem.Click += speakersBToolStripMenuItem_Click;
            // 
            // speakersABToolStripMenuItem
            // 
            speakersABToolStripMenuItem.Name = "speakersABToolStripMenuItem";
            speakersABToolStripMenuItem.Size = new Size(180, 22);
            speakersABToolStripMenuItem.Text = "Speakers A+B";
            speakersABToolStripMenuItem.Click += speakersABToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            ResumeLayout(false);
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