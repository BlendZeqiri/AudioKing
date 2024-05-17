// MainForm.cs
using System;
using System.Windows.Forms;

namespace SoundKing
{
    public partial class MainForm : Form
    {
        private Timer timer;
        private string selectedMusicFilePath;
        private int timeLeft;

        public MainForm()
        {
            object value = InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // 1 second intervals
            timer.Tick += Timer_Tick;
        }


        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTimer.Text, out timeLeft) && !string.IsNullOrEmpty(selectedMusicFilePath))
            {
                timer.Start();
                ShowStopForm(); // Show StopForm when music starts
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
            // Play music logic
            // Show StopForm here as well
        }

        private void ShowStopForm()
        {
            StopForm stopForm = new StopForm();
            stopForm.ShowDialog();
        }
    }
}
