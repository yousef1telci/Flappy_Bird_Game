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
            ((System.ComponentModel.ISupportInitialize)picBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picColumn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picColumnx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picColumnX2).BeginInit();
            SuspendLayout();
            // 
            // picBird
            // 
            picBird.BackColor = Color.Transparent;
            picBird.Image = Properties.Resources.bird;
            picBird.Location = new Point(316, 303);
            picBird.Name = "picBird";
            picBird.Size = new Size(125, 60);
            picBird.SizeMode = PictureBoxSizeMode.StretchImage;
            picBird.TabIndex = 0;
            picBird.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 16;
            timer1.Tick += timer1_Tick;
            // 
            // picColumn
            // 
            picColumn.BackColor = Color.Transparent;
            picColumn.Image = Properties.Resources.column2;
            picColumn.Location = new Point(842, 490);
            picColumn.Name = "picColumn";
            picColumn.Size = new Size(139, 650);
            picColumn.SizeMode = PictureBoxSizeMode.StretchImage;
            picColumn.TabIndex = 1;
            picColumn.TabStop = false;
            // 
            // picColumnx
            // 
            picColumnx.BackColor = Color.Transparent;
            picColumnx.Image = Properties.Resources.column2x;
            picColumnx.Location = new Point(842, -286);
            picColumnx.Name = "picColumnx";
            picColumnx.Size = new Size(139, 551);
            picColumnx.SizeMode = PictureBoxSizeMode.StretchImage;
            picColumnx.TabIndex = 2;
            picColumnx.TabStop = false;
            // 
            // picColumnX2
            // 
            picColumnX2.BackColor = Color.Transparent;
            picColumnX2.Image = Properties.Resources.column2x;
            picColumnX2.Location = new Point(622, -315);
            picColumnX2.Name = "picColumnX2";
            picColumnX2.Size = new Size(139, 551);
            picColumnX2.SizeMode = PictureBoxSizeMode.StretchImage;
            picColumnX2.TabIndex = 3;
            picColumnX2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(984, 687);
            Controls.Add(picColumnX2);
            Controls.Add(picColumnx);
            Controls.Add(picColumn);
            Controls.Add(picBird);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)picColumn).EndInit();
            ((System.ComponentModel.ISupportInitialize)picColumnx).EndInit();
            ((System.ComponentModel.ISupportInitialize)picColumnX2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBird;
        private System.Windows.Forms.Timer timer1;
        private PictureBox picColumn;
        private PictureBox picColumnx;
        private PictureBox picColumnX2;
    }
}
