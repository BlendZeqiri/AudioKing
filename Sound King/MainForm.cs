using System;
using System.Media;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace SoundKing
{
    public partial class MainForm : Form
    {
        public void StopForm.PlayMusic();
        private Timer timer;
        public string selectedMusicFilePath;
        private int timeLeft;
        private SoundPlayer player;
        public int timeleftcopy;
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
                ShowStopForm();
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
                timeleftcopy = timeLeft;
            }
            else
            {
                timer.Stop();
                PlayMusic();
            }
        }



        

        private void ShowStopForm()
        {
            StopForm stopForm = new StopForm(player);
            stopForm.ShowDialog();
        }

        private void txtTimer_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event if needed
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Handle form load event if needed
        }

      


    }
}
