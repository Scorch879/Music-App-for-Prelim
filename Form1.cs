using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using NAudio.Wave;
using TagLib;


namespace Music_App_for_Prelim
{
    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private List<string> filePaths = new List<string>(); // Store file paths
        private List<AudioFileReader> playlist = new List<AudioFileReader>();
        private int currentTrackIndex = 0;

        public Form1()
        {
            InitializeComponent();
            listBoxSongs.HorizontalScrollbar = true;
            axWindowsMediaPlayer.Visible = false; 
            pictureBoxAlbumArt.SizeMode = PictureBoxSizeMode.Zoom; 

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Audio/Video Files|*.mp3;*.wav;*.wma;*.aac;*.m4a;*.mp4",
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    string fileName = Path.GetFileName(file);
                

                    if (!filePaths.Contains(file))
                    {
                        try
                        {
                            playlist.Add(new AudioFileReader(file));
                            filePaths.Add(file);
                            listBoxSongs.Items.Add(fileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Invalid File Format. Please open an audio or video file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"The song '{fileName}' is already in the playlist.", "Duplicate Song", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Paused)
            {
                outputDevice.Play(); // Resume playback instead of restarting
            }
            else
            {
                PlayTrack(currentTrackIndex); // Play from list if not paused
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            outputDevice?.Pause();
            PauseVideo();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
            StopVideo();
            StopAudio();
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            if (outputDevice != null && playlist.Count > 0)
            {
                playlist[currentTrackIndex].Volume = trackVolume.Value / 100f;
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTrackIndex = listBoxSongs.SelectedIndex;
            PlayTrack(currentTrackIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (playlist.Count == 0) return;

            currentTrackIndex = (currentTrackIndex + 1) % playlist.Count; // Move to next song
            PlayTrack(currentTrackIndex);

            listBoxSongs.SelectedIndex = currentTrackIndex; // Update UI selection
        }


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (playlist.Count == 0) return;

            currentTrackIndex = (currentTrackIndex - 1 + playlist.Count) % playlist.Count; // Move to previous song
            PlayTrack(currentTrackIndex);

            listBoxSongs.SelectedIndex = currentTrackIndex; // Update UI selection
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayTrack(int index)
        {
            if (index >= 0 && index < filePaths.Count)
            {
                string filePath = filePaths[index];
                currentTrackIndex = index; // Ensure track index is updated

                if (filePath.EndsWith(".mp4", StringComparison.OrdinalIgnoreCase))
                {
                    StopAudio();
                    axWindowsMediaPlayer.Visible = true;
                    PlayVideo(filePath);
                    return;
                }

                StopVideo();
                axWindowsMediaPlayer.Visible = false;

                if (outputDevice != null)
                {
                    outputDevice.Stop();
                    outputDevice.Dispose();
                }

                outputDevice = new WaveOutEvent();
                playlist[index] = new AudioFileReader(filePath);
                outputDevice.Init(playlist[index]);
                outputDevice.Play();

                lblTrack.Text = "Playing: " + listBoxSongs.Items[index].ToString();
                LoadAlbumArt(filePath);
            }
        }

        private void StopAudio()
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
            }
        }

        private void PauseVideo()
        {
            axWindowsMediaPlayer.Ctlcontrols.pause();

        }

        private void StopVideo()
        {
            axWindowsMediaPlayer.Ctlcontrols.stop();
            axWindowsMediaPlayer.URL = ""; // Clear video source
        }

        private void PlayVideo(string filePath)
        {
            axWindowsMediaPlayer.URL = filePath;
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void LoadAlbumArt(string filePath)
        {
            try
            {
                var file = TagLib.File.Create(filePath);
                if (file.Tag.Pictures.Length > 0)
                {
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    using (MemoryStream ms = new MemoryStream(bin))
                    {
                        pictureBoxAlbumArt.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBoxAlbumArt.Image = Image.FromFile("default_album.png");
                }
            }
            catch
            {
                string defaultAlbumPath = System.IO.Path.Combine(Application.StartupPath, "default_album.png");
                if (System.IO.File.Exists(defaultAlbumPath))
                {
                    pictureBoxAlbumArt.Image = Image.FromFile(defaultAlbumPath);
                }
                else
                {
                    MessageBox.Show("Default album art not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteSelectedSong()
        {
            int index = listBoxSongs.SelectedIndex;
            if (index >= 0)
            {
                listBoxSongs.Items.RemoveAt(index);
                filePaths.RemoveAt(index);
                playlist[index]?.Dispose();
                playlist.RemoveAt(index);

                if (index < listBoxSongs.Items.Count)
                    listBoxSongs.SelectedIndex = index;

                else if (listBoxSongs.Items.Count > 0)
                    listBoxSongs.SelectedIndex = listBoxSongs.Items.Count - 1;
            }
        }

        private void MoveUp()
        {
            int index = listBoxSongs.SelectedIndex;
            if (index > 0)
            {
                SwapItems(index, index - 1);
                listBoxSongs.SelectedIndex = index - 1;
            }
        }

        private void MoveDown()
        {
            int index = listBoxSongs.SelectedIndex;
            if (index < listBoxSongs.Items.Count - 1)
            {
                SwapItems(index, index + 1);
                listBoxSongs.SelectedIndex = index + 1;
            }
        }

        private void SwapItems(int index1, int index2)
        {
            // Swap listBox items
            object tempItem = listBoxSongs.Items[index1];
            listBoxSongs.Items[index1] = listBoxSongs.Items[index2];
            listBoxSongs.Items[index2] = tempItem;

            // Swap file paths
            string tempPath = filePaths[index1];
            filePaths[index1] = filePaths[index2];
            filePaths[index2] = tempPath;

            // Swap playlist entries
            AudioFileReader tempReader = playlist[index1];
            playlist[index1] = playlist[index2];
            playlist[index2] = tempReader;
        }

        private string TrimText(string text, int maxLength)
        {
            return text.Length > maxLength ? text.Substring(0, maxLength) + "..." : text;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedSong();
        }

        private void moveUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void moveDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveDown();
        }
    }
}
