using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class IssuingClient : Form
    {
        public bool save = false;
        public int idOrder;
        readonly DateTime dateСompletion;
        public IssuingClient(int id)
        {
            InitializeComponent();
            idOrder = id;
            int summDetails = 0;
            using Context context = new();
            var listName = context.Details.Where(i => i.Id == idOrder).Select(a => new { a.NameDetails }).ToList();
            var listPrice = context.Details.Where(i => i.Id == idOrder).Select(a => new { a.PriceDetails }).ToList();

            var list = context.Orders.Where(i => i.Id == id).Select(a => new
            {
                a.Client.NameClient,
                a.DateCreation,
                a.DateCompleted,
                a.Equipment,
                a.PriceRepair,
                a.ReturnUnderGuarantee
            }).ToList();

            dateСompletion = DateTime.Parse(list[0].DateCompleted);

            if (listPrice[0].PriceDetails != null)
            {
                List<string> listNameS = new(listName[0].NameDetails);
                List<int> listPriceS = new(listPrice[0].PriceDetails);
                for (int i = 0; i < listPriceS.Count; i++)
                {
                    summDetails += listPriceS[i];
                }
                labelCountDetails.Text = listNameS.Count.ToString() + " шт.";
                labelPriceDetails.Text = summDetails.ToString() + " руб.";
            }

            labelNameClient.Text = list[0].NameClient;
            labelDateCreate.Text = list[0].DateCreation;
            labelEquipment.Text = list[0].Equipment;

            if (list[0].ReturnUnderGuarantee)
                labelPriceRepair.Text = "0";
            else
                labelPriceRepair.Text = list[0].PriceRepair.ToString();

            labelTotalPrice.Text = (summDetails + list[0].PriceRepair).ToString() + " руб.";

            labelGuaranteePeriod.Text = DateTime.Now.AddMonths(Convert.ToInt32(textBoxGuarantee.Text)).Date.ToShortDateString();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkLabelDateNow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void TextBoxGuarantee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateIssue = dateTimePicker1.Value;
            if ((int)(dateIssue - dateСompletion).TotalDays < 0)
            {
                dateIssue = dateСompletion;
                dateTimePicker1.Value = dateСompletion;
            }
            if (Convert.ToInt32(textBoxGuarantee.Text) > 0)
                labelGuaranteePeriod.Text = dateIssue.AddMonths(Convert.ToInt32(textBoxGuarantee.Text)).Date.ToShortDateString();
        }

        private void TextBoxGuarantee_TextChanged(object sender, EventArgs e)
        {
            DateTime dateIssue = dateTimePicker1.Value;
            if (Convert.ToInt32(textBoxGuarantee.Text.Length) > 0)
            {
                labelIsGuarantee.Text = "Гарантия до";
                labelGuaranteePeriod.Text = dateIssue.AddMonths(Convert.ToInt32(textBoxGuarantee.Text)).Date.ToShortDateString();
            } else
            {
                labelIsGuarantee.Text = "Без гарантии";
                labelGuaranteePeriod.Text = "";
            }
        }

        private void ButtonIssueDevice_Click(object sender, EventArgs e)
        {
            if (textBoxGuarantee.Text.Length > 0)
            {
                save = true;
                this.Close();
            }
            else
            {
                Warning warning = new()
                {
                    StartPosition = FormStartPosition.CenterParent,
                    LabelText = "Не введена гарантия!"
                };
                warning.ShowDialog();
            }
        }

        public string DateIssue
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

        public int GuaranteePeriod
        {
            get
            {
                return Convert.ToInt32(this.textBoxGuarantee.Text);
            }
            set
            {
                this.textBoxGuarantee.Text = value.ToString();
            }
        }

        public string DateEndGuarantee
        {
            get
            {
                return this.labelGuaranteePeriod.Text;
            }
            set
            {
                this.labelGuaranteePeriod.Text = value;
            }
        }
    }
}
