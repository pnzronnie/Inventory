namespace WinFormsApp1
{
    partial class CompletedOrder
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelDurationRepair = new Label();
            labelCountDetails = new Label();
            labelPriceDetails = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            linkLabelDateNow = new LinkLabel();
            textBoxPriceRepair = new TextBox();
            label11 = new Label();
            textBoxFoundProblem = new TextBox();
            label12 = new Label();
            label13 = new Label();
            buttonSave = new Button();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(270, 28);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 0;
            label1.Text = "Информация к месту:";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(270, 59);
            label2.Name = "label2";
            label2.Size = new Size(290, 2);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 80);
            label3.Name = "label3";
            label3.Size = new Size(197, 25);
            label3.TabIndex = 2;
            label3.Text = "Длительность ремонта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 105);
            label4.Name = "label4";
            label4.Size = new Size(179, 25);
            label4.TabIndex = 3;
            label4.Text = "Кол-во исп. деталей:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 130);
            label5.Name = "label5";
            label5.Size = new Size(222, 25);
            label5.TabIndex = 4;
            label5.Text = "Суммарная цена деталей:";
            // 
            // labelDurationRepair
            // 
            labelDurationRepair.AutoSize = true;
            labelDurationRepair.Location = new Point(507, 80);
            labelDurationRepair.Name = "labelDurationRepair";
            labelDurationRepair.Size = new Size(51, 25);
            labelDurationRepair.TabIndex = 5;
            labelDurationRepair.Text = "0 дн.";
            // 
            // labelCountDetails
            // 
            labelCountDetails.AutoSize = true;
            labelCountDetails.Location = new Point(507, 105);
            labelCountDetails.Name = "labelCountDetails";
            labelCountDetails.Size = new Size(52, 25);
            labelCountDetails.TabIndex = 6;
            labelCountDetails.Text = "0 шт.";
            // 
            // labelPriceDetails
            // 
            labelPriceDetails.AutoSize = true;
            labelPriceDetails.Location = new Point(507, 130);
            labelPriceDetails.Name = "labelPriceDetails";
            labelPriceDetails.Size = new Size(61, 25);
            labelPriceDetails.TabIndex = 7;
            labelPriceDetails.Text = "0 руб.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(271, 187);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 8;
            label6.Text = "Отчет о ремонте";
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(270, 220);
            label7.Name = "label7";
            label7.Size = new Size(290, 2);
            label7.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(294, 243);
            label8.Name = "label8";
            label8.Size = new Size(207, 25);
            label8.TabIndex = 10;
            label8.Text = "Дата исполнения заказа";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(327, 281);
            label9.Name = "label9";
            label9.Size = new Size(174, 25);
            label9.TabIndex = 11;
            label9.Text = "Стоимость ремонта";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(273, 318);
            label10.Name = "label10";
            label10.Size = new Size(228, 25);
            label10.TabIndex = 12;
            label10.Text = "Найденная неисправность";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(507, 241);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(150, 31);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            // 
            // linkLabelDateNow
            // 
            linkLabelDateNow.AutoSize = true;
            linkLabelDateNow.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabelDateNow.Location = new Point(663, 243);
            linkLabelDateNow.Name = "linkLabelDateNow";
            linkLabelDateNow.Size = new Size(161, 25);
            linkLabelDateNow.TabIndex = 14;
            linkLabelDateNow.TabStop = true;
            linkLabelDateNow.Text = "Сегодняшняя дата";
            linkLabelDateNow.LinkClicked += LinkLabelDateNow_LinkClicked;
            // 
            // textBoxPriceRepair
            // 
            textBoxPriceRepair.Location = new Point(507, 278);
            textBoxPriceRepair.Name = "textBoxPriceRepair";
            textBoxPriceRepair.Size = new Size(150, 31);
            textBoxPriceRepair.TabIndex = 15;
            textBoxPriceRepair.Text = "0";
            textBoxPriceRepair.KeyPress += TextBoxPriceRepair_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(663, 281);
            label11.Name = "label11";
            label11.Size = new Size(46, 25);
            label11.TabIndex = 16;
            label11.Text = "руб.";
            // 
            // textBoxFoundProblem
            // 
            textBoxFoundProblem.Location = new Point(507, 315);
            textBoxFoundProblem.Name = "textBoxFoundProblem";
            textBoxFoundProblem.Size = new Size(589, 31);
            textBoxFoundProblem.TabIndex = 17;
            // 
            // label12
            // 
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Location = new Point(0, 357);
            label12.Name = "label12";
            label12.Size = new Size(1109, 2);
            label12.TabIndex = 18;
            // 
            // label13
            // 
            label13.BorderStyle = BorderStyle.Fixed3D;
            label13.Location = new Point(0, 358);
            label13.Name = "label13";
            label13.Size = new Size(1109, 2);
            label13.TabIndex = 19;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(608, 369);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(241, 34);
            buttonSave.TabIndex = 20;
            buttonSave.Text = "Пометить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(855, 369);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(241, 34);
            buttonExit.TabIndex = 21;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += ButtonExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.complite;
            pictureBox1.Location = new Point(12, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label14
            // 
            label14.BorderStyle = BorderStyle.Fixed3D;
            label14.Location = new Point(236, 1);
            label14.Name = "label14";
            label14.Size = new Size(2, 356);
            label14.TabIndex = 23;
            // 
            // CompletedOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 408);
            Controls.Add(label14);
            Controls.Add(pictureBox1);
            Controls.Add(buttonExit);
            Controls.Add(buttonSave);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(textBoxFoundProblem);
            Controls.Add(label11);
            Controls.Add(textBoxPriceRepair);
            Controls.Add(linkLabelDateNow);
            Controls.Add(dateTimePicker1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(labelPriceDetails);
            Controls.Add(labelCountDetails);
            Controls.Add(labelDurationRepair);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CompletedOrder";
            Text = "Пометка аппарата как отремонтированного";
            Activated += CompletedOrder_Activated;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelDurationRepair;
        private Label labelCountDetails;
        private Label labelPriceDetails;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private LinkLabel linkLabelDateNow;
        private TextBox textBoxPriceRepair;
        private Label label11;
        private TextBox textBoxFoundProblem;
        private Label label12;
        private Label label13;
        private Button buttonSave;
        private Button buttonExit;
        private PictureBox pictureBox1;
        private Label label14;
    }
}