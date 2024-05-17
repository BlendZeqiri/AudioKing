using System;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace SoundKing
{
    public partial class MainForm : Form
    {
        private Timer timer;
        private string selectedMusicFilePath;
        private int timeLeft;
        private SoundPlayer player;

        public MainForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // 1 second intervals
            timer.Tick += Timer_Tick;
        }

        private void btnSelectMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Audio Files|*.wav;*.mp3";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedMusicFilePath = openFileDialog.FileName;
                lblSelectedFile.Text = Path.GetFileName(selectedMusicFilePath);
            }
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTimer.Text, out timeLeft) && !string.IsNullOrEmpty(selectedMusicFilePath))
            {
                timer.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid time and select a music file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
            }
            else
            {
                timer.Stop();
                PlayMusic();
            }
        }

        private void PlayMusic()
        {
            try
            {
                if (Path.GetExtension(selectedMusicFilePath).Equals(".wav", StringComparison.OrdinalIgnoreCase))
                {
                    player = new SoundPlayer(selectedMusicFilePath);
                    player.Play();
                    ShowStopForm();
                }
                else
                {
                    MessageBox.Show("MP3 playback requires additional libraries. Only WAV files are supported out of the box.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing music: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowStopForm()
        {
            StopForm stopForm = new StopForm(player);
            stopForm.ShowDialog();
        }

        private void txtTimer_TextChanged(object sender, EventArgs e)
        {
            // Event handler logic for the txtTimer_TextChanged event
            // This method can be left empty or populated with the desired functionality
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {
            // Event handler logic for the lblTimer_Click event
            // This method can be left empty or populated with the desired functionality
        }
    }
}

