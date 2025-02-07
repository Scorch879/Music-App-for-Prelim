namespace Music_App_for_Prelim
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
            mainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            loadAllMusicToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            playbackToolStripMenuItem = new ToolStripMenuItem();
            nextToolStripMenuItem1 = new ToolStripMenuItem();
            previousToolStripMenuItem1 = new ToolStripMenuItem();
            playToolStripMenuItem = new ToolStripMenuItem();
            pauseToolStripMenuItem = new ToolStripMenuItem();
            stopToolStripMenuItem = new ToolStripMenuItem();
            lblTrack = new Label();
            listBoxSongs = new ListBox();
            listBoxMenuStrip = new ContextMenuStrip(components);
            nextToolStripMenuItem = new ToolStripMenuItem();
            previousToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            moveUpToolStripMenuItem = new ToolStripMenuItem();
            moveDownToolStripMenuItem = new ToolStripMenuItem();
            pictureBoxAlbumArt = new PictureBox();
            axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            groupBox2 = new GroupBox();
            btnLoad = new Button();
            trackVolume = new TrackBar();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnStop = new Button();
            btnPause = new Button();
            btnPlay = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            trackBarSeek = new TrackBar();
            lblCurrentTime = new Label();
            lblTotalTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            mainMenu.SuspendLayout();
            listBoxMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbumArt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackVolume).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSeek).BeginInit();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, playbackToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(1235, 28);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripSeparator2, loadAllMusicToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(65, 24);
            fileToolStripMenuItem.Text = "&Media";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "&Load Music";
            openToolStripMenuItem.Click += btnLoad_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(221, 6);
            // 
            // loadAllMusicToolStripMenuItem
            // 
            loadAllMusicToolStripMenuItem.Checked = true;
            loadAllMusicToolStripMenuItem.CheckState = CheckState.Checked;
            loadAllMusicToolStripMenuItem.Image = Properties.Resources._4973292;
            loadAllMusicToolStripMenuItem.Name = "loadAllMusicToolStripMenuItem";
            loadAllMusicToolStripMenuItem.Size = new Size(224, 26);
            loadAllMusicToolStripMenuItem.Text = "Load All Music";
            loadAllMusicToolStripMenuItem.Click += loadAllMusicToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.images;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += btnExit_Click;
            // 
            // playbackToolStripMenuItem
            // 
            playbackToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nextToolStripMenuItem1, previousToolStripMenuItem1, playToolStripMenuItem, pauseToolStripMenuItem, stopToolStripMenuItem });
            playbackToolStripMenuItem.Name = "playbackToolStripMenuItem";
            playbackToolStripMenuItem.Size = new Size(81, 24);
            playbackToolStripMenuItem.Text = "Playback";
            // 
            // nextToolStripMenuItem1
            // 
            nextToolStripMenuItem1.Image = Properties.Resources.Next;
            nextToolStripMenuItem1.Name = "nextToolStripMenuItem1";
            nextToolStripMenuItem1.Size = new Size(147, 26);
            nextToolStripMenuItem1.Text = "Next";
            nextToolStripMenuItem1.Click += btnNext_Click;
            // 
            // previousToolStripMenuItem1
            // 
            previousToolStripMenuItem1.Image = Properties.Resources.Previous;
            previousToolStripMenuItem1.Name = "previousToolStripMenuItem1";
            previousToolStripMenuItem1.Size = new Size(147, 26);
            previousToolStripMenuItem1.Text = "Previous";
            previousToolStripMenuItem1.Click += btnPrevious_Click;
            // 
            // playToolStripMenuItem
            // 
            playToolStripMenuItem.Image = Properties.Resources.Play;
            playToolStripMenuItem.Name = "playToolStripMenuItem";
            playToolStripMenuItem.Size = new Size(147, 26);
            playToolStripMenuItem.Text = "Play";
            playToolStripMenuItem.Click += btnPlay_Click;
            // 
            // pauseToolStripMenuItem
            // 
            pauseToolStripMenuItem.Image = Properties.Resources.Pause;
            pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            pauseToolStripMenuItem.Size = new Size(147, 26);
            pauseToolStripMenuItem.Text = "Pause";
            pauseToolStripMenuItem.Click += btnPause_Click;
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.Image = Properties.Resources.Stop;
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.Size = new Size(147, 26);
            stopToolStripMenuItem.Text = "Stop";
            stopToolStripMenuItem.Click += btnStop_Click;
            // 
            // lblTrack
            // 
            lblTrack.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTrack.AutoSize = true;
            lblTrack.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrack.Location = new Point(324, 546);
            lblTrack.Name = "lblTrack";
            lblTrack.Size = new Size(248, 41);
            lblTrack.TabIndex = 1;
            lblTrack.Text = "No Track Loaded";
            // 
            // listBoxSongs
            // 
            listBoxSongs.ContextMenuStrip = listBoxMenuStrip;
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.Location = new Point(26, 77);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(275, 544);
            listBoxSongs.TabIndex = 8;
            listBoxSongs.SelectedIndexChanged += listBoxSongs_SelectedIndexChanged;
            // 
            // listBoxMenuStrip
            // 
            listBoxMenuStrip.ImageScalingSize = new Size(20, 20);
            listBoxMenuStrip.Items.AddRange(new ToolStripItem[] { nextToolStripMenuItem, previousToolStripMenuItem, deleteToolStripMenuItem, moveUpToolStripMenuItem, moveDownToolStripMenuItem });
            listBoxMenuStrip.Name = "contextMenuStrip1";
            listBoxMenuStrip.Size = new Size(163, 134);
            // 
            // nextToolStripMenuItem
            // 
            nextToolStripMenuItem.Image = Properties.Resources.Next;
            nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            nextToolStripMenuItem.Size = new Size(162, 26);
            nextToolStripMenuItem.Text = "Next";
            nextToolStripMenuItem.Click += btnNext_Click;
            // 
            // previousToolStripMenuItem
            // 
            previousToolStripMenuItem.Image = Properties.Resources.Previous;
            previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            previousToolStripMenuItem.Size = new Size(162, 26);
            previousToolStripMenuItem.Text = "Previous";
            previousToolStripMenuItem.Click += btnPrevious_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.Delete;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(162, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // moveUpToolStripMenuItem
            // 
            moveUpToolStripMenuItem.Image = Properties.Resources.Move_up;
            moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            moveUpToolStripMenuItem.Size = new Size(162, 26);
            moveUpToolStripMenuItem.Text = "Move up";
            moveUpToolStripMenuItem.Click += moveUpToolStripMenuItem_Click;
            // 
            // moveDownToolStripMenuItem
            // 
            moveDownToolStripMenuItem.Image = Properties.Resources.Move_down;
            moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            moveDownToolStripMenuItem.Size = new Size(162, 26);
            moveDownToolStripMenuItem.Text = "Move Down";
            moveDownToolStripMenuItem.Click += moveDownToolStripMenuItem_Click;
            // 
            // pictureBoxAlbumArt
            // 
            pictureBoxAlbumArt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxAlbumArt.Image = Properties.Resources.default_album;
            pictureBoxAlbumArt.Location = new Point(324, 46);
            pictureBoxAlbumArt.Name = "pictureBoxAlbumArt";
            pictureBoxAlbumArt.Size = new Size(887, 491);
            pictureBoxAlbumArt.TabIndex = 11;
            pictureBoxAlbumArt.TabStop = false;
            // 
            // axWindowsMediaPlayer
            // 
            axWindowsMediaPlayer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            axWindowsMediaPlayer.Enabled = true;
            axWindowsMediaPlayer.Location = new Point(324, 46);
            axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            axWindowsMediaPlayer.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer.OcxState");
            axWindowsMediaPlayer.Size = new Size(887, 660);
            axWindowsMediaPlayer.TabIndex = 21;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLoad);
            groupBox2.Controls.Add(trackVolume);
            groupBox2.Location = new Point(26, 629);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 153);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.Location = new Point(11, 17);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(251, 60);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load Music ";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // trackVolume
            // 
            trackVolume.Location = new Point(41, 83);
            trackVolume.Maximum = 100;
            trackVolume.Name = "trackVolume";
            trackVolume.Size = new Size(191, 56);
            trackVolume.TabIndex = 4;
            trackVolume.Value = 50;
            trackVolume.Scroll += trackVolume_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 46);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 24;
            label1.Text = "Playlist";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnStop, 2, 0);
            tableLayoutPanel1.Controls.Add(btnPause, 1, 0);
            tableLayoutPanel1.Controls.Add(btnPlay, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPrevious, 0, 1);
            tableLayoutPanel1.Controls.Add(btnNext, 2, 1);
            tableLayoutPanel1.Location = new Point(324, 643);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(890, 125);
            tableLayoutPanel1.TabIndex = 27;
            // 
            // btnStop
            // 
            btnStop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStop.Dock = DockStyle.Fill;
            btnStop.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            btnStop.Location = new Point(595, 3);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(292, 56);
            btnStop.TabIndex = 23;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnPause
            // 
            btnPause.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPause.Dock = DockStyle.Fill;
            btnPause.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            btnPause.Location = new Point(299, 3);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(290, 56);
            btnPause.TabIndex = 22;
            btnPause.Text = "||";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnPlay
            // 
            btnPlay.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPlay.BackgroundImageLayout = ImageLayout.Center;
            btnPlay.Dock = DockStyle.Fill;
            btnPlay.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            btnPlay.Location = new Point(3, 3);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(290, 56);
            btnPlay.TabIndex = 21;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPrevious.Dock = DockStyle.Fill;
            btnPrevious.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            btnPrevious.Location = new Point(3, 65);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(290, 57);
            btnPrevious.TabIndex = 24;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNext.Dock = DockStyle.Fill;
            btnNext.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            btnNext.Location = new Point(595, 65);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(292, 57);
            btnNext.TabIndex = 25;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // trackBarSeek
            // 
            trackBarSeek.Location = new Point(372, 599);
            trackBarSeek.Maximum = 100;
            trackBarSeek.Name = "trackBarSeek";
            trackBarSeek.Size = new Size(777, 56);
            trackBarSeek.TabIndex = 28;
            trackBarSeek.Scroll += trackBarSeek_Scroll;
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.AutoSize = true;
            lblCurrentTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentTime.Location = new Point(324, 597);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(56, 25);
            lblCurrentTime.TabIndex = 29;
            lblCurrentTime.Text = "00:00";
            // 
            // lblTotalTime
            // 
            lblTotalTime.AutoSize = true;
            lblTotalTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTime.Location = new Point(1155, 596);
            lblTotalTime.Name = "lblTotalTime";
            lblTotalTime.Size = new Size(56, 25);
            lblTotalTime.TabIndex = 30;
            lblTotalTime.Text = "00:00";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += currentTrackTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1235, 794);
            Controls.Add(axWindowsMediaPlayer);
            Controls.Add(lblTotalTime);
            Controls.Add(lblCurrentTime);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(pictureBoxAlbumArt);
            Controls.Add(listBoxSongs);
            Controls.Add(lblTrack);
            Controls.Add(mainMenu);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(trackBarSeek);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenu;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "-[9k, dewqwe'";
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            listBoxMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbumArt).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackVolume).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBarSeek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label lblTrack;
        private ListBox listBoxSongs;
        private ContextMenuStrip listBoxMenuStrip;
        private ToolStripMenuItem nextToolStripMenuItem;
        private ToolStripMenuItem previousToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private PictureBox pictureBoxAlbumArt;
        private ToolStripMenuItem moveUpToolStripMenuItem;
        private ToolStripMenuItem moveDownToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private GroupBox groupBox2;
        private Button btnLoad;
        private TrackBar trackVolume;
        private ToolStripMenuItem playbackToolStripMenuItem;
        private ToolStripMenuItem nextToolStripMenuItem1;
        private ToolStripMenuItem previousToolStripMenuItem1;
        private ToolStripMenuItem playToolStripMenuItem;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNext;
        private Button btnStop;
        private Button btnPause;
        private Button btnPlay;
        private Button btnPrevious;
        private ToolStripMenuItem loadAllMusicToolStripMenuItem;
        private TrackBar trackBarSeek;
        private Label lblCurrentTime;
        private Label lblTotalTime;
        private System.Windows.Forms.Timer timer1;
    }
}
