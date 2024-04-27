using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class CalculatingEmployeeSalaries : Form
    {
        public CalculatingEmployeeSalaries()
        {
            InitializeComponent();
            UpdateComboBox();
            UpdateTable();
        }

        private void UpdateComboBox()
        {
            Context context = new();
            var list = context.Orders.Where(i => !i.InProgress).Select(i => new { i.DateCompleted }).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (comboBoxYears.Items.IndexOf(DateTime.Parse(list[i].DateCompleted).Year) < 0)
                {
                    comboBoxYears.Items.Add(DateTime.Parse(list[i].DateCompleted).Year);
                }
            }


            if (comboBoxYears.Items.IndexOf(DateTime.Now.Year) < 0)
                comboBoxYears.Items.Add(DateTime.Now.Year);

            comboBoxYears.SelectedIndex = 0;
        }

        private int CheckMonth()
        {
            int numberMonth = 0;

            var checkedButton = panel1.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            switch (checkedButton.Text)
            {
                case "Январь":
                    numberMonth = 01;
                    break;
                case "Февраль":
                    numberMonth = 02;
                    break;
                case "Март":
                    numberMonth = 03;
                    break;
                case "Апрель":
                    numberMonth = 04;
                    break;
                case "Май":
                    numberMonth = 05;
                    break;
                case "Июнь":
                    numberMonth = 06;
                    break;
                case "Июль":
                    numberMonth = 07;
                    break;
                case "Август":
                    numberMonth = 08;
                    break;
                case "Сентябрь":
                    numberMonth = 09;
                    break;
                case "Октябрь":
                    numberMonth = 10;
                    break;
                case "Ноябрь":
                    numberMonth = 11;
                    break;
                case "Декабрь":
                    numberMonth = 12;
                    break;
            }

            return numberMonth;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void RadioButton11_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void RadioButton12_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            Context context = new();
            var list = context.Orders.Where(i => !i.Deleted && !i.InProgress).ToList();

            var listMasters = context.Masters.ToList();
            int salary = 0;
            int countOrders = 0;
            int profit = 0;
            int countCompletedOrders = 0;

            dataGridView1.Rows.Clear();

            for (int i = 0; i < listMasters.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (DateTime.Parse(list[i].DateCompleted).Month == CheckMonth() &&
                        DateTime.Parse(list[0].DateCompleted).Year == Convert.ToInt32(comboBoxYears.Text))
                    {
                        profit += list[j].PriceRepair;
                        countCompletedOrders++;
                        if (listMasters[i].TypeSalary == "percentOrganization")
                        {
                            salary += list[j].PriceRepair;
                            if (list[j].MasterId == listMasters[i].Id)
                                countOrders++;
                        }
                        else
                        {
                            if (list[j].MasterId == listMasters[i].Id)
                            {
                                countOrders++;
                                if (listMasters[i].TypeSalary == "percentMaster")
                                    salary += list[j].PriceRepair;

                            }
                        }
                    }
                }
                if (listMasters[i].TypeSalary == "rate")
                    dataGridView1.Rows.Add(listMasters[i].NameMaster, listMasters[i].Rate, countOrders);
                else /*if (listMasters[i].TypeSalary == "percentMaster")*/
                    dataGridView1.Rows.Add(listMasters[i].NameMaster,
                            (double)listMasters[i].Rate / 100.0 * salary, countOrders);
                labelProfit.Text = profit.ToString() + " руб.";
                labelCountCompletedOrders.Text = countCompletedOrders.ToString();
                countCompletedOrders = 0;
                profit = 0;
                salary = 0;
                countOrders = 0;
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
