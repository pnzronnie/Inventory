namespace WinFormsApp1
{
    partial class EnterBrandForm
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
            btnAdd = new Button();
            btnExit = new Button();
            label1 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            textBoxPrice = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(49, 182);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Tag = "Yes";
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(281, 182);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(161, 34);
            btnExit.TabIndex = 3;
            btnExit.Tag = "No";
            btnExit.Text = "Отмена";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 75);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 4;
            label1.Text = "Название";
            // 
            // nameTextBox
            // 
            nameTextBox.ForeColor = Color.Black;
            nameTextBox.HideSelection = false;
            nameTextBox.Location = new Point(214, 72);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(228, 31);
            nameTextBox.TabIndex = 0;
            nameTextBox.KeyPress += NameTextBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 112);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 5;
            label2.Text = "Цена";
            label2.Visible = false;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(214, 109);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(228, 31);
            textBoxPrice.TabIndex = 1;
            textBoxPrice.Visible = false;
            textBoxPrice.Click += TextBoxPrice_Click;
            textBoxPrice.KeyPress += TextBoxPrice_KeyPress;
            // 
            // EnterBrandForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 228);
            Controls.Add(textBoxPrice);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EnterBrandForm";
            Text = "Добавление новой фирмы";
            Activated += EnterBrandForm_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnExit;
        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private TextBox textBoxPrice;
    }
}