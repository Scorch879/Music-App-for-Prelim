using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NAudio.Wave;

namespace Music_App_for_Prelim
{
    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private List<AudioFileReader> playlist;
        private int currentTrackIndex = 0;

        public Form1()
        {
            InitializeComponent();
            playlist = new List<AudioFileReader>();
            listBoxSongs.HorizontalScrollbar = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Audio Files|*.mp3;*.wav;*.wma;*.aac;*.m4a",
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    string fileName = System.IO.Path.GetFileName(file);
                    string trimmedFileName = TrimText(fileName, 40);

                  
                    if (!listBoxSongs.Items.Contains(trimmedFileName))
                    {
                        playlist.Add(new AudioFileReader(file));
                        listBoxSongs.Items.Add(trimmedFileName); 
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
            if (index >= 0 && index < playlist.Count)
            {
                if (outputDevice != null)
                {
                    outputDevice.Stop();
                    outputDevice.Dispose();
                }

                outputDevice = new WaveOutEvent();
                outputDevice.Init(playlist[index]);
                outputDevice.Play();
                lblTrack.Text = "Playing: " + listBoxSongs.Items[index].ToString();
            }
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
            if (playlist.Count == 0) return; 

         
            currentTrackIndex = (currentTrackIndex + 1) % playlist.Count; /
            PlayTrack(currentTrackIndex);

         
            listBoxSongs.SelectedIndex = currentTrackIndex;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (playlist.Count == 0) return;

           
            currentTrackIndex = (currentTrackIndex - 1 + playlist.Count) % playlist.Count; 
            PlayTrack(currentTrackIndex);

         
            listBoxSongs.SelectedIndex = currentTrackIndex;
        }

        private string TrimText(string text, int maxLength)
        {
            return text.Length > maxLength ? text.Substring(0, maxLength) + "..." : text;
        }
    }
}