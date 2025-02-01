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
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            lblTrack = new Label();
            trackVolume = new TrackBar();
            btnLoad = new Button();
            listBoxSongs = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            nextToolStripMenuItem = new ToolStripMenuItem();
            previousToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            moveUpToolStripMenuItem = new ToolStripMenuItem();
            moveDownToolStripMenuItem = new ToolStripMenuItem();
            pictureBoxAlbumArt = new PictureBox();
            btnNext = new Button();
            btnPrevious = new Button();
            btnStop = new Button();
            btnPause = new Button();
            btnPlay = new Button();
            axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackVolume).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbumArt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer).BeginInit();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(1135, 28);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(181, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += btnLoad_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(181, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += btnExit_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new Size(150, 26);
            contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size(150, 26);
            indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(150, 26);
            searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(147, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(150, 26);
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // lblTrack
            // 
            lblTrack.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTrack.AutoSize = true;
            lblTrack.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrack.Location = new Point(336, 289);
            lblTrack.Name = "lblTrack";
            lblTrack.Size = new Size(248, 41);
            lblTrack.TabIndex = 1;
            lblTrack.Text = "No Track Loaded";
            // 
            // trackVolume
            // 
            trackVolume.Location = new Point(64, 512);
            trackVolume.Maximum = 100;
            trackVolume.Name = "trackVolume";
            trackVolume.Size = new Size(186, 56);
            trackVolume.TabIndex = 2;
            trackVolume.Value = 50;
            trackVolume.Scroll += trackVolume_Scroll;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.Location = new Point(64, 440);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(186, 51);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load Music ";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // listBoxSongs
            // 
            listBoxSongs.ContextMenuStrip = contextMenuStrip1;
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.Location = new Point(26, 57);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(275, 364);
            listBoxSongs.TabIndex = 8;
            listBoxSongs.SelectedIndexChanged += listBoxSongs_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { nextToolStripMenuItem, previousToolStripMenuItem, deleteToolStripMenuItem, moveUpToolStripMenuItem, moveDownToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(159, 124);
            // 
            // nextToolStripMenuItem
            // 
            nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            nextToolStripMenuItem.Size = new Size(158, 24);
            nextToolStripMenuItem.Text = "Next";
            nextToolStripMenuItem.Click += btnNext_Click;
            // 
            // previousToolStripMenuItem
            // 
            previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            previousToolStripMenuItem.Size = new Size(158, 24);
            previousToolStripMenuItem.Text = "Previous";
            previousToolStripMenuItem.Click += btnPrevious_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(158, 24);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // moveUpToolStripMenuItem
            // 
            moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            moveUpToolStripMenuItem.Size = new Size(158, 24);
            moveUpToolStripMenuItem.Text = "Move up";
            // 
            // moveDownToolStripMenuItem
            // 
            moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            moveDownToolStripMenuItem.Size = new Size(158, 24);
            moveDownToolStripMenuItem.Text = "Move Down";
            // 
            // pictureBoxAlbumArt
            // 
            pictureBoxAlbumArt.Image = Properties.Resources.default_album;
            pictureBoxAlbumArt.Location = new Point(336, 57);
            pictureBoxAlbumArt.Name = "pictureBoxAlbumArt";
            pictureBoxAlbumArt.Size = new Size(387, 217);
            pictureBoxAlbumArt.TabIndex = 11;
            pictureBoxAlbumArt.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnNext.Location = new Point(553, 427);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 44);
            btnNext.TabIndex = 20;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnPrevious.Location = new Point(418, 427);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 44);
            btnPrevious.TabIndex = 19;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnStop.Location = new Point(616, 364);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 44);
            btnStop.TabIndex = 18;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnPause
            // 
            btnPause.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnPause.Location = new Point(493, 364);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(94, 44);
            btnPause.TabIndex = 17;
            btnPause.Text = "||";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnPlay.Location = new Point(378, 364);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(94, 44);
            btnPlay.TabIndex = 16;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // axWindowsMediaPlayer
            // 
            axWindowsMediaPlayer.Enabled = true;
            axWindowsMediaPlayer.Location = new Point(767, 57);
            axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            axWindowsMediaPlayer.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer.OcxState");
            axWindowsMediaPlayer.Size = new Size(345, 219);
            axWindowsMediaPlayer.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 618);
            Controls.Add(axWindowsMediaPlayer);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnStop);
            Controls.Add(btnPause);
            Controls.Add(btnPlay);
            Controls.Add(pictureBoxAlbumArt);
            Controls.Add(listBoxSongs);
            Controls.Add(btnLoad);
            Controls.Add(trackVolume);
            Controls.Add(lblTrack);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "Form1";
            Text = "Music App";
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackVolume).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbumArt).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label lblTrack;
        private TrackBar trackVolume;
        private Button btnLoad;
        private ListBox listBoxSongs;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem nextToolStripMenuItem;
        private ToolStripMenuItem previousToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private PictureBox pictureBoxAlbumArt;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnStop;
        private Button btnPause;
        private Button btnPlay;
        private ToolStripMenuItem moveUpToolStripMenuItem;
        private ToolStripMenuItem moveDownToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
    }
}
