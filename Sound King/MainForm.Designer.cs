using System.Windows.Forms;
using System;

namespace SoundKing
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Button btnSelectMusic;
        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Timer timeru;
       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.btnSelectMusic = new System.Windows.Forms.Button();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.timeru = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Blue;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Snow;
            this.lblTimer.Location = new System.Drawing.Point(4, 18);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(67, 25);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "Time:";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // txtTimer
            // 
            this.txtTimer.BackColor = System.Drawing.Color.Red;
            this.txtTimer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTimer.Location = new System.Drawing.Point(79, 21);
            this.txtTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(377, 26);
            this.txtTimer.TabIndex = 1;
            this.txtTimer.TextChanged += new System.EventHandler(this.txtTimer_TextChanged);
            // 
            // btnSelectMusic
            // 
            this.btnSelectMusic.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSelectMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectMusic.Location = new System.Drawing.Point(362, 65);
            this.btnSelectMusic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectMusic.Name = "btnSelectMusic";
            this.btnSelectMusic.Size = new System.Drawing.Size(94, 46);
            this.btnSelectMusic.TabIndex = 2;
            this.btnSelectMusic.Text = "Music";
            this.btnSelectMusic.UseVisualStyleBackColor = false;
            this.btnSelectMusic.Click += new System.EventHandler(this.btnSelectMusic_Click);
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.AutoSize = true;
            this.lblSelectedFile.Location = new System.Drawing.Point(183, 65);
            this.lblSelectedFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(117, 20);
            this.lblSelectedFile.TabIndex = 3;
            this.lblSelectedFile.Text = "No file selected";
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.BackColor = System.Drawing.Color.Cyan;
            this.btnStartTimer.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTimer.ForeColor = System.Drawing.Color.White;
            this.btnStartTimer.Location = new System.Drawing.Point(41, 65);
            this.btnStartTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(307, 46);
            this.btnStartTimer.TabIndex = 4;
            this.btnStartTimer.Text = "Start";
            this.btnStartTimer.UseVisualStyleBackColor = false;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(497, 120);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.lblSelectedFile);
            this.Controls.Add(this.btnSelectMusic);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.lblTimer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "War Timer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
