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
            volume30ToolStripMenuItem = new ToolStripMenuItem();
            volume35ToolStripMenuItem = new ToolStripMenuItem();
            volume40ToolStripMenuItem = new ToolStripMenuItem();
            volume45ToolStripMenuItem = new ToolStripMenuItem();
            volume50ToolStripMenuItem = new ToolStripMenuItem();
            volume55ToolStripMenuItem = new ToolStripMenuItem();
            volume60ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            muteToolStripMenuItem = new ToolStripMenuItem();
            unmuteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { speakersAToolStripMenuItem, speakersBToolStripMenuItem, speakersABToolStripMenuItem, toolStripSeparator1, volume30ToolStripMenuItem, volume35ToolStripMenuItem, volume40ToolStripMenuItem, volume45ToolStripMenuItem, volume50ToolStripMenuItem, volume55ToolStripMenuItem, volume60ToolStripMenuItem, toolStripSeparator2, muteToolStripMenuItem, unmuteToolStripMenuItem, toolStripSeparator3, exitToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(147, 308);
            // 
            // speakersAToolStripMenuItem
            // 
            speakersAToolStripMenuItem.Name = "speakersAToolStripMenuItem";
            speakersAToolStripMenuItem.Size = new Size(146, 22);
            speakersAToolStripMenuItem.Text = "Speakers A";
            speakersAToolStripMenuItem.Click += speakersAToolStripMenuItem_Click;
            // 
            // speakersBToolStripMenuItem
            // 
            speakersBToolStripMenuItem.Name = "speakersBToolStripMenuItem";
            speakersBToolStripMenuItem.Size = new Size(146, 22);
            speakersBToolStripMenuItem.Text = "Speakers B";
            speakersBToolStripMenuItem.Click += speakersBToolStripMenuItem_Click;
            // 
            // speakersABToolStripMenuItem
            // 
            speakersABToolStripMenuItem.Name = "speakersABToolStripMenuItem";
            speakersABToolStripMenuItem.Size = new Size(146, 22);
            speakersABToolStripMenuItem.Text = "Speakers A+B";
            speakersABToolStripMenuItem.Click += speakersABToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(143, 6);
            // 
            // volume30ToolStripMenuItem
            // 
            volume30ToolStripMenuItem.Name = "volume30ToolStripMenuItem";
            volume30ToolStripMenuItem.Size = new Size(146, 22);
            volume30ToolStripMenuItem.Text = "Volume 30";
            volume30ToolStripMenuItem.Click += volume30ToolStripMenuItem_Click;
            // 
            // volume35ToolStripMenuItem
            // 
            volume35ToolStripMenuItem.Name = "volume35ToolStripMenuItem";
            volume35ToolStripMenuItem.Size = new Size(146, 22);
            volume35ToolStripMenuItem.Text = "Volume 35";
            volume35ToolStripMenuItem.Click += volume35ToolStripMenuItem_Click;
            // 
            // volume40ToolStripMenuItem
            // 
            volume40ToolStripMenuItem.Name = "volume40ToolStripMenuItem";
            volume40ToolStripMenuItem.Size = new Size(146, 22);
            volume40ToolStripMenuItem.Text = "Volume 40";
            volume40ToolStripMenuItem.Click += volume40ToolStripMenuItem_Click;
            // 
            // volume45ToolStripMenuItem
            // 
            volume45ToolStripMenuItem.Name = "volume45ToolStripMenuItem";
            volume45ToolStripMenuItem.Size = new Size(146, 22);
            volume45ToolStripMenuItem.Text = "Volume 45";
            volume45ToolStripMenuItem.Click += volume45ToolStripMenuItem_Click;
            // 
            // volume50ToolStripMenuItem
            // 
            volume50ToolStripMenuItem.Name = "volume50ToolStripMenuItem";
            volume50ToolStripMenuItem.Size = new Size(146, 22);
            volume50ToolStripMenuItem.Text = "Volume 50";
            volume50ToolStripMenuItem.Click += volume50ToolStripMenuItem_Click;
            // 
            // volume55ToolStripMenuItem
            // 
            volume55ToolStripMenuItem.Name = "volume55ToolStripMenuItem";
            volume55ToolStripMenuItem.Size = new Size(146, 22);
            volume55ToolStripMenuItem.Text = "Volume 55";
            volume55ToolStripMenuItem.Click += volume55ToolStripMenuItem_Click;
            // 
            // volume60ToolStripMenuItem
            // 
            volume60ToolStripMenuItem.Name = "volume60ToolStripMenuItem";
            volume60ToolStripMenuItem.Size = new Size(146, 22);
            volume60ToolStripMenuItem.Text = "Volume 60";
            volume60ToolStripMenuItem.Click += volume60ToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(143, 6);
            // 
            // muteToolStripMenuItem
            // 
            muteToolStripMenuItem.Name = "muteToolStripMenuItem";
            muteToolStripMenuItem.Size = new Size(146, 22);
            muteToolStripMenuItem.Text = "Mute";
            muteToolStripMenuItem.Click += muteToolStripMenuItem_Click;
            // 
            // unmuteToolStripMenuItem
            // 
            unmuteToolStripMenuItem.Name = "unmuteToolStripMenuItem";
            unmuteToolStripMenuItem.Size = new Size(146, 22);
            unmuteToolStripMenuItem.Text = "Unmute";
            unmuteToolStripMenuItem.Click += unmuteToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(146, 22);
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
        private ToolStripMenuItem volume50ToolStripMenuItem;
        private ToolStripMenuItem volume40ToolStripMenuItem;
        private ToolStripMenuItem volume30ToolStripMenuItem;
        private ToolStripMenuItem muteToolStripMenuItem;
        private ToolStripMenuItem unmuteToolStripMenuItem;
        private ToolStripMenuItem volume60ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem volume35ToolStripMenuItem;
        private ToolStripMenuItem volume45ToolStripMenuItem;
        private ToolStripMenuItem volume55ToolStripMenuItem;
    }
}