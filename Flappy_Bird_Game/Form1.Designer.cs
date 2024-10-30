namespace Flappy_Bird_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picBird = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            picColumn = new PictureBox();
            picColumnx = new PictureBox();
            picColumnX2 = new PictureBox();
            picColumn2 = new PictureBox();
            labelScore = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picColumn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picColumnx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picColumnX2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picColumn2).BeginInit();
            SuspendLayout();
            // 
            // picBird
            // 
            picBird.BackColor = Color.Transparent;
            picBird.Image = Properties.Resources.bird__1__export;
            picBird.Location = new Point(249, 234);
            picBird.Name = "picBird";
            picBird.Size = new Size(76, 77);
            picBird.SizeMode = PictureBoxSizeMode.StretchImage;
            picBird.TabIndex = 0;
            picBird.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // picColumn
            // 
            picColumn.BackColor = Color.Transparent;
            picColumn.Image = Properties.Resources.pipe_llllexport___Kopya;
            picColumn.Location = new Point(761, 453);
            picColumn.Name = "picColumn";
            picColumn.Size = new Size(116, 468);
            picColumn.SizeMode = PictureBoxSizeMode.StretchImage;
            picColumn.TabIndex = 1;
            picColumn.TabStop = false;
            // 
            // picColumnx
            // 
            picColumnx.BackColor = Color.Transparent;
            picColumnx.Image = Properties.Resources.pipedownSSS_export;
            picColumnx.Location = new Point(761, -297);
            picColumnx.Name = "picColumnx";
            picColumnx.Size = new Size(116, 468);
            picColumnx.SizeMode = PictureBoxSizeMode.StretchImage;
            picColumnx.TabIndex = 2;
            picColumnx.TabStop = false;
            // 
            // picColumnX2
            // 
            picColumnX2.BackColor = Color.Transparent;
            picColumnX2.Image = Properties.Resources.pipedownSSS_export;
            picColumnX2.Location = new Point(1111, -297);
            picColumnX2.Name = "picColumnX2";
            picColumnX2.Size = new Size(116, 468);
            picColumnX2.SizeMode = PictureBoxSizeMode.StretchImage;
            picColumnX2.TabIndex = 3;
            picColumnX2.TabStop = false;
            // 
            // picColumn2
            // 
            picColumn2.BackColor = Color.Transparent;
            picColumn2.Image = Properties.Resources.pipe_llllexport___Kopya;
            picColumn2.Location = new Point(1103, 494);
            picColumn2.Name = "picColumn2";
            picColumn2.Size = new Size(124, 258);
            picColumn2.SizeMode = PictureBoxSizeMode.StretchImage;
            picColumn2.TabIndex = 4;
            picColumn2.TabStop = false;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.BackColor = Color.Transparent;
            labelScore.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelScore.Location = new Point(144, 9);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(33, 38);
            labelScore.TabIndex = 5;
            labelScore.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(1, 10);
            label1.Name = "label1";
            label1.Size = new Size(100, 37);
            label1.TabIndex = 6;
            label1.Text = "score : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1482, 750);
            Controls.Add(label1);
            Controls.Add(labelScore);
            Controls.Add(picColumn2);
            Controls.Add(picColumnX2);
            Controls.Add(picColumnx);
            Controls.Add(picColumn);
            Controls.Add(picBird);
            DoubleBuffered = true;
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flappy Bird Game";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)picColumn).EndInit();
            ((System.ComponentModel.ISupportInitialize)picColumnx).EndInit();
            ((System.ComponentModel.ISupportInitialize)picColumnX2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picColumn2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBird;
        private System.Windows.Forms.Timer timer1;
        private PictureBox picColumn;
        private PictureBox picColumnx;
        private PictureBox picColumnX2;
        private PictureBox picColumn2;
        private Label labelScore;
        private Label label1;
    }
}
