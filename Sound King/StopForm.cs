using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace SoundKing
{
    public partial class StopForm : Form
    {
        private SoundPlayer player;
        public int timeleftcopy;
        public string selectedMusicFilePath;

        private Button btnStop;
        private Label leftTimer;
        private Timer timera;
        private System.ComponentModel.IContainer components;
        private System.ComponentModel.IContainer componentsa = null;
        public StopForm(SoundPlayer soundPlayer)
        {
            InitializeComponent();
            player = soundPlayer;
        }


        public void PlayMusic()
        {
            try
            {
                if (Path.GetExtension(selectedMusicFilePath).Equals(".wav", StringComparison.OrdinalIgnoreCase))
                {
                    player = new SoundPlayer(selectedMusicFilePath);
                    player.Play();

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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStop = new System.Windows.Forms.Button();
            this.leftTimer = new System.Windows.Forms.Label();
            this.timera = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Lime;
            this.btnStop.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Snow;
            this.btnStop.Location = new System.Drawing.Point(188, 50);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 50);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // leftTimer
            // 
            this.leftTimer.AutoSize = true;
            this.leftTimer.BackColor = System.Drawing.Color.Blue;
            this.leftTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftTimer.ForeColor = System.Drawing.Color.Snow;
            this.leftTimer.Location = new System.Drawing.Point(13, 61);
            this.leftTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leftTimer.Name = "leftTimer";
            this.leftTimer.Size = new System.Drawing.Size(130, 32);
            this.leftTimer.TabIndex = 3;
            this.leftTimer.Text = "Time: #s";
            this.leftTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.leftTimer.Click += new System.EventHandler(this.leftTimer_Click);
            // 
            // timera
            // 
            this.timera.Enabled = true;
            this.timera.Interval = 1000;
            this.timera.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // StopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.leftTimer);
            this.Controls.Add(this.btnStop);
            this.Name = "StopForm";
            this.Text = "Stop Music";
            this.Load += new System.EventHandler(this.StopForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                player.Stop();
            }
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Counter(); // Call Counter() function on every tick
        }

        private void Counter()
        {
            if (timeleftcopy >= 1) // Assuming timeleftcopy is a variable accessible in this scope
            {
            this.leftTimer.Text = $"Time: {timeleftcopy} #s";    
            }
            else
            {
                leftTimer.Text = "DONE"; // Clear the text if timeleftcopy is less than 1
            }
        }

        private void StopForm_Load(object sender, EventArgs e)
        {
            // Optional: Add any additional initialization logic here
        }
       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (componentsa != null))
            {
                componentsa.Dispose();
            }
            base.Dispose(disposing);
        }

        private void leftTimer_Click(object sender, EventArgs e)
        {

        }

        private void StopForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
