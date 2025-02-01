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
                    string trimmedFileName = TrimText(fileName, 40);

                    if (!filePaths.Contains(file))
                    {
                        try
                        {
                            playlist.Add(new AudioFileReader(file));
                            filePaths.Add(file);
                            listBoxSongs.Items.Add(trimmedFileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Invalid File Format. Please open an audio or video file!","Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"The song '{trimmedFileName}' is already in the playlist.", "Duplicate Song", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayTrack(currentTrackIndex);
        }

        private void PlayTrack(int index)
        {
            if (index >= 0 && index < filePaths.Count)
            {
                string filePath = filePaths[index];

                if (filePath.EndsWith(".mp4")) // Handle video playback
                {
                    PlayVideo(filePath);
                    return;
                }

                if (outputDevice != null)
                {
                    outputDevice.Stop();
                    outputDevice.Dispose();
                }

                outputDevice = new WaveOutEvent();
                AudioFileReader reader = new AudioFileReader(filePath);

                if (playlist.Count > index)
                {
                    playlist[index]?.Dispose();
                    playlist[index] = reader;
                }

                outputDevice.Init(reader);
                outputDevice.Play();

                lblTrack.Text = "Playing: " + listBoxSongs.Items[index].ToString();
                LoadAlbumArt(filePath);
            }
        }

        private void PlayVideo(string filePath)
        {
            axWindowsMediaPlayer.URL = filePath;
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            outputDevice?.Pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
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
            if (filePaths.Count == 0) return;
            currentTrackIndex = (currentTrackIndex + 1) % filePaths.Count;
            listBoxSongs.SelectedIndex = currentTrackIndex;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (filePaths.Count == 0) return;
            currentTrackIndex = (currentTrackIndex - 1 + filePaths.Count) % filePaths.Count;
            listBoxSongs.SelectedIndex = currentTrackIndex;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private string TrimText(string text, int maxLength)
        {
            return text.Length > maxLength ? text.Substring(0, maxLength) + "..." : text;
        }
    }
}
