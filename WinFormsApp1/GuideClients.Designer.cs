namespace WinFormsApp1
{
    partial class GuideClients
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
            dataGridView1 = new DataGridView();
            textBoxEnterName = new TextBox();
            buttonWhite = new Button();
            buttonNormal = new Button();
            buttonBlack = new Button();
            buttonAll = new Button();
            buttonExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(12, 77);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(670, 388);
            dataGridView1.TabIndex = 0;
            // 
            // textBoxEnterName
            // 
            textBoxEnterName.Location = new Point(12, 471);
            textBoxEnterName.Name = "textBoxEnterName";
            textBoxEnterName.Size = new Size(220, 31);
            textBoxEnterName.TabIndex = 1;
            textBoxEnterName.TextChanged += TextBoxEnterName_TextChanged;
            // 
            // buttonWhite
            // 
            buttonWhite.BackgroundImage = Properties.Resources.m6_3_1;
            buttonWhite.BackgroundImageLayout = ImageLayout.Zoom;
            buttonWhite.Location = new Point(78, 12);
            buttonWhite.Name = "buttonWhite";
            buttonWhite.Size = new Size(50, 50);
            buttonWhite.TabIndex = 2;
            buttonWhite.UseVisualStyleBackColor = true;
            buttonWhite.Click += ButtonWhite_Click;
            // 
            // buttonNormal
            // 
            buttonNormal.BackgroundImage = Properties.Resources.m6_1;
            buttonNormal.BackgroundImageLayout = ImageLayout.Zoom;
            buttonNormal.Location = new Point(144, 12);
            buttonNormal.Name = "buttonNormal";
            buttonNormal.Size = new Size(50, 50);
            buttonNormal.TabIndex = 3;
            buttonNormal.UseVisualStyleBackColor = true;
            buttonNormal.Click += ButtonNormal_Click;
            // 
            // buttonBlack
            // 
            buttonBlack.BackgroundImage = Properties.Resources.m6_3_2;
            buttonBlack.BackgroundImageLayout = ImageLayout.Zoom;
            buttonBlack.Location = new Point(210, 12);
            buttonBlack.Name = "buttonBlack";
            buttonBlack.Size = new Size(50, 50);
            buttonBlack.TabIndex = 4;
            buttonBlack.UseVisualStyleBackColor = true;
            buttonBlack.Click += ButtonBlack_Click;
            // 
            // buttonAll
            // 
            buttonAll.BackgroundImage = Properties.Resources.menAll;
            buttonAll.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAll.Location = new Point(12, 12);
            buttonAll.Name = "buttonAll";
            buttonAll.Size = new Size(50, 50);
            buttonAll.TabIndex = 5;
            buttonAll.UseVisualStyleBackColor = true;
            buttonAll.Click += ButtonAll_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(503, 479);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(179, 34);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += ButtonExit_Click;
            // 
            // GuideClients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 525);
            Controls.Add(buttonExit);
            Controls.Add(buttonAll);
            Controls.Add(buttonBlack);
            Controls.Add(buttonNormal);
            Controls.Add(buttonWhite);
            Controls.Add(textBoxEnterName);
            Controls.Add(dataGridView1);
            Name = "GuideClients";
            Text = "Клиенты";
            Activated += GuideClients_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxEnterName;
        private Button buttonWhite;
        private Button buttonNormal;
        private Button buttonBlack;
        private Button buttonAll;
        private Button buttonExit;
    }
}