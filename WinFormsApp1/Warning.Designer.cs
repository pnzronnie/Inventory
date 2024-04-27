namespace WinFormsApp1
{
    partial class Warning
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            buttonExit = new Button();
            buttonYes = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(187, 29);
            label1.Name = "label1";
            label1.Size = new Size(377, 110);
            label1.TabIndex = 0;
            label1.Text = "Вы не заполнили обязательные поля!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.warning;
            pictureBox1.Location = new Point(12, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(148, 29);
            label2.Name = "label2";
            label2.Size = new Size(2, 110);
            label2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(235, 235, 235);
            textBox1.Enabled = false;
            textBox1.Location = new Point(-5, 156);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(581, 61);
            textBox1.TabIndex = 5;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(381, 168);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(181, 34);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "ОК";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += ButtonExit_Click;
            // 
            // buttonYes
            // 
            buttonYes.Location = new Point(194, 168);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(181, 34);
            buttonYes.TabIndex = 7;
            buttonYes.Text = "Да";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Visible = false;
            buttonYes.Click += ButtonYes_Click;
            // 
            // Warning
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 213);
            Controls.Add(buttonYes);
            Controls.Add(buttonExit);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Warning";
            Text = "Внимание";
            Activated += Warning_Activated;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private Button buttonExit;
        private Button buttonYes;
    }
}