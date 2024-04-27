using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class CompletedOrder : Form
    {
        public bool save = false;
        readonly DateTime dateCreate;
        public CompletedOrder(int id)
        {
            InitializeComponent();
            int summDetails = 0;
            using Context context = new();
            var listPrice = context.Details.Where(i => i.Id == id).Select(a => new { a.PriceDetails }).ToList();
            var list = context.Orders.Where(i => i.Id == id).Select(a => new { a.DateCreation, a.DateCompleted }).ToList();
            dateCreate = DateTime.Parse(list[0].DateCreation);
            DateTime dateComplete = DateTime.Now;

            if (listPrice[0].PriceDetails != null)
            {
                List<int> listPriceS = new(listPrice[0].PriceDetails);
                for (int i = 0; i < listPriceS.Count; i++)
                {
                    summDetails += listPriceS[i];
                }
                labelPriceDetails.Text = summDetails.ToString() + " руб.";
                labelCountDetails.Text = listPriceS.Count.ToString() + " шт.";
            }
            labelDurationRepair.Text = ((int)(dateComplete - dateCreate).TotalDays).ToString() + " дн.";
        }

        private void LinkLabelDateNow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxPriceRepair_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (textBoxPriceRepair.Text.Length > 0)
            {
                save = true;
                this.Close();
            }
            else
            {
                Warning warning = new()
                {
                    StartPosition = FormStartPosition.CenterParent,
                    LabelText = "Цена за ремонт не введена!"
                };
                warning.ShowDialog();
            }
        }

        private void CompletedOrder_Activated(object sender, EventArgs e)
        {
            textBoxPriceRepair.Focus();
            textBoxPriceRepair.SelectAll();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateComplete = dateTimePicker1.Value;
            if ((int)(dateComplete - dateCreate).TotalDays < 0)
            {
                dateComplete = dateCreate;
                dateTimePicker1.Value = dateCreate;
            }
            labelDurationRepair.Text = ((int)(dateComplete - dateCreate).TotalDays).ToString() + " дн.";
        }

        public string DateComplete
        {
            get
            {
                return this.dateTimePicker1.Value.ToString();
            }
            set
            {
                this.dateTimePicker1.Value = DateTime.Parse(value);
            }
        }

        public int PriceRepair
        {
            get
            {
                return Convert.ToInt32(this.textBoxPriceRepair.Text);
            }
            set
            {
                textBoxPriceRepair.Text = value.ToString();
            }
        }

        public string FoundProblem
        {
            get 
            {
                return this.textBoxFoundProblem.Text;
            }
            set
            {
                this.textBoxFoundProblem.Text = value;
            }
        }

        public bool EnabledPrice
        {
            get { return textBoxPriceRepair.Enabled; }
            set { textBoxPriceRepair.Enabled = value;}
        }
    }
}
