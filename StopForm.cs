using System;
using System.Media;
using System.Windows.Forms;

namespace SoundKing
{
    public partial class StopForm : Form
    {
        private SoundPlayer player;

        public StopForm(SoundPlayer soundPlayer)
        {
            InitializeComponent();
            player = soundPlayer;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Stop();
            this.Close();
        }

        private void InitializeComponent()
        {
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(35, 30);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 50);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // StopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.Controls.Add(this.btnStop);
            this.Name = "StopForm";
            this.Text = "Stop Music";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnStop;
    }
}
