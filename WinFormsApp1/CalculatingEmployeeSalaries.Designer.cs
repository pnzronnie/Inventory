﻿namespace WinFormsApp1
{
    partial class CalculatingEmployeeSalaries
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            radioButton12 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dataGridView1 = new DataGridView();
            colMaster = new DataGridViewTextBoxColumn();
            colSalary = new DataGridViewTextBoxColumn();
            colOrdersCount = new DataGridViewTextBoxColumn();
            comboBoxYears = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonExit = new Button();
            label7 = new Label();
            labelProfit = new Label();
            label8 = new Label();
            labelCountCompletedOrders = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton12);
            panel1.Controls.Add(radioButton11);
            panel1.Controls.Add(radioButton10);
            panel1.Controls.Add(radioButton9);
            panel1.Controls.Add(radioButton8);
            panel1.Controls.Add(radioButton7);
            panel1.Controls.Add(radioButton6);
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(12, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 438);
            panel1.TabIndex = 0;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(20, 401);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(106, 29);
            radioButton12.TabIndex = 13;
            radioButton12.TabStop = true;
            radioButton12.Text = "Декабрь";
            radioButton12.UseVisualStyleBackColor = true;
            radioButton12.CheckedChanged += RadioButton12_CheckedChanged;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(20, 366);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(100, 29);
            radioButton11.TabIndex = 12;
            radioButton11.TabStop = true;
            radioButton11.Text = "Ноябрь";
            radioButton11.UseVisualStyleBackColor = true;
            radioButton11.CheckedChanged += RadioButton11_CheckedChanged;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(20, 331);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(106, 29);
            radioButton10.TabIndex = 11;
            radioButton10.TabStop = true;
            radioButton10.Text = "Октябрь";
            radioButton10.UseVisualStyleBackColor = true;
            radioButton10.CheckedChanged += RadioButton10_CheckedChanged;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(20, 296);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(113, 29);
            radioButton9.TabIndex = 10;
            radioButton9.TabStop = true;
            radioButton9.Text = "Сентябрь";
            radioButton9.UseVisualStyleBackColor = true;
            radioButton9.CheckedChanged += RadioButton9_CheckedChanged;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(20, 261);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(90, 29);
            radioButton8.TabIndex = 8;
            radioButton8.TabStop = true;
            radioButton8.Text = "Август";
            radioButton8.UseVisualStyleBackColor = true;
            radioButton8.CheckedChanged += RadioButton8_CheckedChanged;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(20, 226);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(83, 29);
            radioButton7.TabIndex = 7;
            radioButton7.TabStop = true;
            radioButton7.Text = "Июль";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += RadioButton7_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(20, 191);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(84, 29);
            radioButton6.TabIndex = 6;
            radioButton6.TabStop = true;
            radioButton6.Text = "Июнь";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += RadioButton6_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(20, 156);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(72, 29);
            radioButton5.TabIndex = 5;
            radioButton5.TabStop = true;
            radioButton5.Text = "Май";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += RadioButton5_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(20, 121);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(97, 29);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "Апрель";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += RadioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(20, 86);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(80, 29);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Март";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += RadioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(20, 51);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(107, 29);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Февраль";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += RadioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(20, 16);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(97, 29);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Январь";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += RadioButton1_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colMaster, colSalary, colOrdersCount });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(233, 18);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(544, 477);
            dataGridView1.TabIndex = 1;
            // 
            // colMaster
            // 
            colMaster.HeaderText = "Мастер";
            colMaster.MinimumWidth = 8;
            colMaster.Name = "colMaster";
            colMaster.Width = 180;
            // 
            // colSalary
            // 
            colSalary.HeaderText = "Зарплата";
            colSalary.MinimumWidth = 8;
            colSalary.Name = "colSalary";
            colSalary.Width = 170;
            // 
            // colOrdersCount
            // 
            colOrdersCount.HeaderText = "Выполненные заказы";
            colOrdersCount.MinimumWidth = 8;
            colOrdersCount.Name = "colOrdersCount";
            colOrdersCount.Width = 130;
            // 
            // comboBoxYears
            // 
            comboBoxYears.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYears.FormattingEnabled = true;
            comboBoxYears.Location = new Point(12, 75);
            comboBoxYears.Name = "comboBoxYears";
            comboBoxYears.Size = new Size(162, 33);
            comboBoxYears.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 4;
            label1.Text = "Параметры";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(0, 50);
            label2.Name = "label2";
            label2.Size = new Size(224, 2);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(224, -2);
            label3.Name = "label3";
            label3.Size = new Size(2, 570);
            label3.TabIndex = 6;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(0, 567);
            label4.Name = "label4";
            label4.Size = new Size(804, 2);
            label4.TabIndex = 7;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(225, -2);
            label5.Name = "label5";
            label5.Size = new Size(2, 570);
            label5.TabIndex = 8;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(0, 568);
            label6.Name = "label6";
            label6.Size = new Size(804, 2);
            label6.TabIndex = 9;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(577, 576);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(185, 34);
            buttonExit.TabIndex = 10;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += ButtonExit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(270, 502);
            label7.Name = "label7";
            label7.Size = new Size(261, 25);
            label7.TabIndex = 11;
            label7.Text = "Общая прибыль организации:";
            // 
            // labelProfit
            // 
            labelProfit.AutoSize = true;
            labelProfit.Location = new Point(527, 502);
            labelProfit.Name = "labelProfit";
            labelProfit.Size = new Size(61, 25);
            labelProfit.TabIndex = 12;
            labelProfit.Text = "0 руб.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(233, 531);
            label8.Name = "label8";
            label8.Size = new Size(298, 25);
            label8.TabIndex = 13;
            label8.Text = "Количество выполненных заказов:";
            // 
            // labelCountCompletedOrders
            // 
            labelCountCompletedOrders.AutoSize = true;
            labelCountCompletedOrders.Location = new Point(527, 531);
            labelCountCompletedOrders.Name = "labelCountCompletedOrders";
            labelCountCompletedOrders.Size = new Size(22, 25);
            labelCountCompletedOrders.TabIndex = 14;
            labelCountCompletedOrders.Text = "0";
            // 
            // CalculatingEmployeeSalaries
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 616);
            Controls.Add(labelCountCompletedOrders);
            Controls.Add(label8);
            Controls.Add(labelProfit);
            Controls.Add(label7);
            Controls.Add(buttonExit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxYears);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "CalculatingEmployeeSalaries";
            Text = "Расчет зарплаты сотрудников организации";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton12;
        private RadioButton radioButton11;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private DataGridView dataGridView1;
        private ComboBox comboBoxYears;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonExit;
        private DataGridViewTextBoxColumn colMaster;
        private DataGridViewTextBoxColumn colSalary;
        private DataGridViewTextBoxColumn colOrdersCount;
        private Label label7;
        private Label labelProfit;
        private Label label8;
        private Label labelCountCompletedOrders;
    }
}