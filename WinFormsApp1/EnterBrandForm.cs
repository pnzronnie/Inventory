using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class EnterBrandForm : Form
    {
        public bool Add = false;
        public EnterBrandForm()
        {
            InitializeComponent();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length == 0 || (textBoxPrice.Visible && textBoxPrice.Text.Length == 0))
            {
                Warning warning = new()
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                warning.ShowDialog();

                if (nameTextBox.Text.Length == 0)
                    label1.ForeColor = Color.Red;
                else
                    label1.ForeColor = Color.Black;

                if (textBoxPrice.Text.Length == 0 && textBoxPrice.Text.Length == 0)
                    label2.ForeColor = Color.Red;
                else
                    label2.ForeColor = Color.Black;
            }
            else
            {
                Add = true;
                this.Close();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (nameTextBox.Text.Length == 0 || (textBoxPrice.Visible && textBoxPrice.Text.Length == 0))
                {
                    Warning warning = new()
                    {
                        StartPosition = FormStartPosition.CenterParent
                    };
                    warning.ShowDialog();
                    if (nameTextBox.Text.Length == 0)
                        label1.ForeColor = Color.Red;
                    else
                        label1.ForeColor = Color.Black;

                    if (textBoxPrice.Text.Length == 0 && textBoxPrice.Text.Length == 0)
                        label2.ForeColor = Color.Red;
                    else
                        label2.ForeColor = Color.Black;
                }
                else
                {
                    Add = true;
                    this.Close();
                }
            }
        }

        private void EnterBrandForm_Activated(object sender, EventArgs e)
        {
            nameTextBox.Focus();
            nameTextBox.SelectAll();
        }

        private void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 13)
                e.Handled = true;

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (nameTextBox.Text.Length == 0 || textBoxPrice.Text.Length == 0)
                {
                    Warning warning = new()
                    {
                        StartPosition = FormStartPosition.CenterParent
                    };
                    warning.ShowDialog();
                }
                else
                {
                    Add = true;
                    this.Close();
                }
            }
        }

        private void TextBoxPrice_Click(object sender, EventArgs e)
        {
            nameTextBox.SelectionLength = 0;
        }

        public string BtnText
        {
            get
            {
                return this.btnAdd.Text;
            }
            set
            {
                this.btnAdd.Text = value;
            }
        }

        public string TextBoxText
        {
            get
            {
                return this.nameTextBox.Text;
            }
            set
            {
                this.nameTextBox.Text = value;
            }
        }

        public string TextBox2Text
        {
            get
            {
                return this.textBoxPrice.Text;
            }
            set
            {
                this.textBoxPrice.Text = value;
            }
        }

        public string LabelText
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }

        public bool LabelVisible
        {
            get
            {
                return this.label2.Visible;
            }
            set
            {
                this.label2.Visible = value;
            }
        }

        public bool PriceVisible
        {
            get
            {
                return this.textBoxPrice.Visible;
            }
            set
            {
                this.textBoxPrice.Visible = value;
            }
        }

        public string ReturnText
        {
            get { return nameTextBox.Text; }
        }

        public int ReturnPrice
        {
            get { return Convert.ToInt32(textBoxPrice.Text); }
        }
    }
}
