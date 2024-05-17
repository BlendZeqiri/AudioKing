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
            if (player != null)
            {
                player.Stop();
            }
            this.Close();
        }
    }
}
