// StopForm.cs
using System;
using System.Windows.Forms;

namespace SoundKing
{
    public partial class StopForm : Form
    {
        public StopForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // Add your initialization code here
            // Example:
            // this.lblTitle = new System.Windows.Forms.Label();
            // this.lblTitle.Text = "Title";
            // this.lblTitle.Location = new System.Drawing.Point(10, 10);
            // this.Controls.Add(this.lblTitle);
            this.ResumeLayout(false);
        }



        private void btnStop_Click(object sender, EventArgs e)
        {
            // Stop the music here (implementation depends on how you play music)
            // Close the StopForm
            this.Close();
        }
    }
}
