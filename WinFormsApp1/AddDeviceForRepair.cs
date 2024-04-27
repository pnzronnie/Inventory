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
    public partial class AddDeviceForRepair : Form
    {
        int numberPage = 1;
        readonly List<string> oldClients = [];
        public AddDeviceForRepair()
        {
            InitializeComponent();
            UpdateComboBox(0);
            UpdateComboBox(1);
            UpdateComboBox(2);
            textBoxIdOrder.Text = IdKeyOrder().ToString();
            Context context = new();
            var listClient = context.Clients.Select(a => new { a.NameClient }).ToList();
            if (listClient.Count > 0)
            {
                for (int i = 0; i < listClient.Count; i++)
                {
                    oldClients.Add(listClient[i].NameClient);
                }
            }

            foundInTable.Click += FoundInTable_Click;
            lastId.Click += LastId_Click;
            checkId.Click += CheckId_Click;
        }

        private void FoundInTable_Click(object? sender, EventArgs e)
        {
            Context context = new();
            var list = context.Orders.Select(a => new { a.Id }).OrderBy(a => a.Id).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if ((i + 1) != list[i].Id)
                {
                    textBoxIdOrder.Text = (i + 1).ToString();
                    break;
                }
            }
        }

        private void LastId_Click(object? sender, EventArgs e)
        {
            textBoxIdOrder.Text = IdKeyOrder().ToString();
        }

        private void CheckId_Click(object? sender, EventArgs e)
        {
            Context context = new();
            var list = context.Orders.Select(a => new { a.Id }).ToList();

            if (CheckIdOrder())
            {
                Warning warning = new()
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Text = "Проверка номера кватанции",
                    LabelText = "Квитанция с таким номером уже существует!"
                };
                warning.ShowDialog();
            }

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            switch (numberPage)
            {
                case 2:
                    panel2.Visible = false;
                    panel1.Visible = true;
                    this.numberPage = 1;
                    break;
                case 3:
                    panel3.Visible = false;
                    panel2.Visible = true;
                    this.numberPage = 2;
                    break;
                case 4:
                    panel4.Visible = false;
                    panel3.Visible = true;
                    this.numberPage = 3;
                    buttonFurther.Text = "Далее";
                    break;

            }
            Steps();

        }

        private void ButtonFurther_Click(object sender, EventArgs e)
        {
            Context context = new();
            switch (numberPage)
            {
                case 1:
                    panel1.Visible = false;
                    panel2.Visible = true;
                    this.numberPage = 2;
                    break;
                case 2:
                    panel2.Visible = false;
                    panel3.Visible = true;
                    this.numberPage = 3;
                    break;
                case 3:
                    panel3.Visible = false;
                    panel4.Visible = true;
                    this.numberPage = 4;
                    buttonFurther.Text = "Готово";
                    break;
                case 4:
                    if (comboBoxMaster.Items.Count == 0 ||
                         comboBoxDevice.Items.Count == 0 ||
                          comboBoxBrand.Items.Count == 0)
                    {
                        Warning warning = new()
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        warning.ShowDialog();

                        if (comboBoxMaster.Items.Count == 0)
                            labelMaster.ForeColor = Color.Red;
                        else
                            labelMaster.ForeColor = Color.Black;
                        if (comboBoxDevice.Items.Count == 0)
                            labelDevice.ForeColor = Color.Red;
                        else
                            labelDevice.ForeColor = Color.Black;
                        if (comboBoxBrand.Items.Count == 0)
                            labelBrand.ForeColor = Color.Red;
                        else
                            labelBrand.ForeColor = Color.Black;
                    }
                    else if (textBoxNameClient.Text == "")
                    {
                        labelNameClient.ForeColor = Color.Red;
                        Warning warning = new()
                        {
                            StartPosition = FormStartPosition.CenterParent,
                            LabelText = "Вы не заполнили ФИО заказчика!"
                        };
                        warning.ShowDialog();
                    }
                    else if (CheckIdOrder())
                    {
                        Warning warning = new()
                        {
                            StartPosition = FormStartPosition.CenterParent,
                            Text = "Внимание",
                            LabelText = "Квитанция с таким номером уже существует!"
                        };
                        warning.ShowDialog();
                    }
                    else
                    {
                        int idClient = IdKeyClient();
                        int idOrder = Convert.ToInt32(textBoxIdOrder.Text);

                        if (!CheckClient())
                        {
                            CRUD.AddAsyncClient(idClient, textBoxNameClient.Text,
                                textBoxAddress.Text, textBoxWorkPhone.Text, textBoxHomePhone.Text, "normal");
                        }
                        CRUD.AddAsyncOrder(
                            idOrder,
                            context.Clients.Where(a => a.NameClient == textBoxNameClient.Text).ToList()[0].Id,
                            context.Masters.Where(a => a.NameMaster == comboBoxMaster.Text).ToList()[0].Id,
                            dateTimePicker1.Text,
                            null,
                            null,
                            context.TypeTechnices.Where(a => a.NameTypeTechnic == comboBoxDevice.Text).ToList()[0].Id,
                            context.BrandTechnices.Where(a => a.NameBrandTechnic == comboBoxBrand.Text).ToList()[0].Id,
                            textBoxModel.Text,
                            textBoxFactoryNumber.Text,
                            textBoxEquipment.Text,
                            textBoxDiagnosis.Text,
                            textBoxNote.Text,
                            checkBox1.Checked,
                            true,
                            0,
                            null,
                            false,
                            false,
                            false,
                            0,
                            null);
                        CRUD.AddAsyncDetails(idOrder, null, null);
                        this.Close();
                    }
                    break;
            }
            Steps();
        }

        private void Steps()
        {
            switch (numberPage)
            {
                case 1:
                    labelStepName.Text = "Выбор мастера по ремонту и даты принятия (шаг 1 из 4)";
                    break;
                case 2:
                    labelStepName.Text = "Сведения об аппарате (шаг 2 из 4)";
                    break;
                case 3:
                    labelStepName.Text = "Сведения о заказчике (шаг 3 из 4)";
                    break;
                case 4:
                    labelStepName.Text = "Заметки (шаг 4 из 4)";
                    break;
            }
        }

        private void LinkLabelDateCreation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void LinkLabelListMaster_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddMaster addMaster = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addMaster.ShowDialog();
            UpdateComboBox(0);
        }

        private void UpdateComboBox(int idBox)
        {
            switch (idBox)
            {
                case 0:
                    comboBoxMaster.DataSource = null;
                    comboBoxMaster.Items.Clear();
                    using (Context context = new())
                    {
                        comboBoxMaster.ValueMember = "Id";
                        comboBoxMaster.DisplayMember = "NameMaster";
                        comboBoxMaster.DataSource = context.Masters.ToList();
                    }
                    break;
                case 1:
                    comboBoxDevice.DataSource = null;
                    comboBoxDevice.Items.Clear();
                    using (Context context = new())
                    {
                        comboBoxDevice.ValueMember = "Id";
                        comboBoxDevice.DisplayMember = "NameTypeTechnic";
                        comboBoxDevice.DataSource = context.TypeTechnices.ToList();
                    }
                    break;
                case 2:
                    comboBoxBrand.DataSource = null;
                    comboBoxBrand.Items.Clear();
                    using (Context context = new())
                    {
                        comboBoxBrand.ValueMember = "Id";
                        comboBoxBrand.DisplayMember = "NameBrandTechnic";
                        comboBoxBrand.DataSource = context.BrandTechnices.ToList();
                    }
                    break;

            }
        }

        private void ButtonNumber_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(MousePosition);
        }

        private bool CheckIdOrder()
        {
            Context context = new();
            bool matching = false;
            var list = context.Orders.Select(a => new { a.Id }).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (Convert.ToInt32(textBoxIdOrder.Text) == list[i].Id)
                {
                    matching = true;
                    break;
                }
            }
            return matching;
        }

        private bool CheckClient()
        {
            Context context = new();
            bool matching = false;

            var list = context.Clients.Select(a => new { a.NameClient }).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (textBoxNameClient.Text == list[i].NameClient)
                {
                    matching = true;
                    break;
                }
            }
            return matching;
        }

        private static int IdKeyOrder()
        {
            int idKey;
            using (Context context = new())
            {
                if (context.Orders.Any())
                {
                    idKey = context.Orders.OrderBy(i => i.Id).Last().Id;
                    idKey++;
                }
                else { idKey = 1; }
            }
            return idKey;
        }

        private static int IdKeyClient()
        {
            int idKey;
            using (Context context = new())
            {
                if (context.Clients.Any())
                {
                    idKey = context.Clients.OrderBy(i => i.Id).Last().Id;
                    idKey++;
                }
                else { idKey = 1; }
            }
            return idKey;
        }

        private void ListBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = listBoxClient.SelectedIndex;
            if (id >= 0)
            {
                textBoxNameClient.Text = listBoxClient.Items[id].ToString();

                listBoxClient.Items.Clear();
                listBoxClient.Visible = false;

                labelTypeClient.Text = "Старый клиент";

                textBoxNameClient.Focus();
                textBoxNameClient.SelectionStart = textBoxNameClient.TextLength;
            }
        }

        private void TextBoxNameClient_TextChanged(object sender, EventArgs e)
        {
            listBoxClient.Items.Clear();
            listBoxClient.Visible = false;

            for (int i = 0; i < oldClients.Count; i++)
            {
                if (oldClients[i].StartsWith(textBoxNameClient.Text) && textBoxNameClient.Text.Length > 0)
                {
                    listBoxClient.Visible = true;
                    listBoxClient.Items.Add(oldClients[i]);
                }
            }

            if (listBoxClient.Items.Count == 0)
                labelTypeClient.Text = "Новый клиент";
        }

        private void AddDeviceForRepair_Activated(object sender, EventArgs e)
        {
            buttonNumber.Focus();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkLabelDevice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddDevice addDevice = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addDevice.ShowDialog();
            UpdateComboBox(1);
        }

        private void LinkLabelBrand_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddBrand addBrand = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addBrand.ShowDialog();
            UpdateComboBox(2);
        }
    }
}
