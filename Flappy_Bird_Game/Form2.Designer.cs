namespace Flappy_Bird_Game
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictRestart = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictRestart).BeginInit();
            SuspendLayout();
            // 
            // pictRestart
            // 
            pictRestart.BackColor = Color.Transparent;
            //pictRestart.Image = Properties.Resources.restart;
            pictRestart.Location = new Point(403, 494);
            pictRestart.Name = "pictRestart";
            pictRestart.Size = new Size(183, 90);
            pictRestart.SizeMode = PictureBoxSizeMode.Zoom;
            pictRestart.TabIndex = 1;
            pictRestart.TabStop = false;
            pictRestart.Click += pictRestart_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSkyBlue;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(412, 413);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 2;
            label1.Text = "RESTART";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            //BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(984, 687);
            Controls.Add(label1);
            Controls.Add(pictRestart);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictRestart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictRestart;
        private Label label1;
    }
}