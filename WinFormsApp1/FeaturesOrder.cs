using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class FeaturesOrder : Form
    {
        public int idOrder;
        public string statusOrder;
        public FeaturesOrder(int id, string status)
        {
            InitializeComponent();
            idOrder = id;
            statusOrder = status;
            this.Text = "Свойства устройства (заказ №" + id + ")";
            Context context = new();
            var list = context.Orders.Where(i => i.Id == id).ToList();

            //IdOrder
            textBoxIdOrder.Text = list[0].Id.ToString();

            //StatusOrder
            if (list[0].InProgress)
                textBoxStatus.Text = "Находится в ремонте";
            else
                textBoxStatus.Text = "Отремонтирован";

            //NameMaster
            UpdateComboBox(0);
            var listMaster = context.Masters.Where(i => i.Id == list[0].MasterId).ToList();
            comboBoxMaster.SelectedIndex = comboBoxMaster.FindStringExact(listMaster[0].NameMaster);

            //DateCreation
            dateCreation.Value = DateTime.Parse(list[0].DateCreation);

            //Device
            UpdateComboBox(1);
            var listDevice = context.TypeTechnices.Where(i => i.Id == list[0].TypeTechnicId).ToList();
            comboBoxDevice.SelectedIndex = comboBoxDevice.FindStringExact(listDevice[0].NameTypeTechnic);

            //Brand
            UpdateComboBox(2);
            var listBrand = context.BrandTechnices.Where(i => i.Id == list[0].BrandTechnicId).ToList();
            comboBoxBrand.SelectedIndex = comboBoxBrand.FindStringExact(listBrand[0].NameBrandTechnic);

            //Model
            textBoxModel.Text = list[0].ModelTechnic;

            //FactoryNumber
            textBoxFactoryNumber.Text = list[0].FactoryNumber;

            //UrgentRepair
            checkBoxUrgentRepair.Checked = list[0].UrgentRepairs;

            //Equipment
            textBoxEquipment.Text = list[0].Equipment;

            //Diagnosis
            textBoxDiagnosis.Text = list[0].Diagnosis;

            //Note
            textBoxNote.Text = list[0].Note;

            //NameClient
            var listClient = context.Clients.Where(i => i.Id == list[0].ClientId).ToList();
            textBoxClientName.Text = listClient[0].NameClient;

            //Address
            textBoxAddress.Text = listClient[0].Address;

            //HomePhone
            textBoxHomePhone.Text = listClient[0].NumberPhoneHome;

            //WorkPhone
            textBoxWorkPhone.Text = listClient[0].NumberPhoneWork;

            //TypeClient
            switch (listClient[0].TypeClient)
            {
                case "normal":
                    textBoxTypeClient.Text = "Обычный клиент"; break;
                case "white":
                    textBoxTypeClient.Text = "В белом списке"; break;
                case "black":
                    textBoxTypeClient.Text = "В черном списке"; break;
            }

            switch (status)
            {
                case "Completed":
                    OrderComplete();
                    break;
                case "GuaranteeIssue":
                    OrderIssue();
                    break;
                case "Archive":
                    OrderIssue();
                    break;
            }
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

        public void OrderComplete()
        {
            Context context = new();
            int summDetails = 0;
            var listName = context.Details.Where(i => i.Id == idOrder).Select(a => new { a.NameDetails }).ToList();
            var listPrice = context.Details.Where(i => i.Id == idOrder).Select(a => new { a.PriceDetails }).ToList();
            var list = context.Orders.Where(i => i.Id == idOrder).Select(a => new { a.FoundProblem, a.PriceRepair }).ToList();

            if (listName[0].NameDetails != null)
            {
                List<string> listNameS = new(listName[0].NameDetails);
                List<int> listPriceS = new(listPrice[0].PriceDetails);
                for (int i = 0; i < listNameS.Count; i++)
                {
                    listBox1.Items.Add((i + 1) + ". " + listNameS[i] + " (" + listPriceS[i] + " руб.)");
                    summDetails += listPriceS[i];
                }
                textBoxCountDetails.Text = listNameS.Count.ToString() + " шт.";
                textBoxPriceDetails.Text = summDetails.ToString() + " руб.";
            }

            labelFoundProblem.ForeColor = Color.Black;
            labelPriceRepair.ForeColor = Color.Black;
            label18.ForeColor = Color.Black;
            textBoxFoundProblem.Enabled = true;
            textBoxFoundProblem.Text = list[0].FoundProblem;
            textBoxPriceRepair.Enabled = true;
            textBoxPriceRepair.Text = list[0].PriceRepair.ToString();
        }

        public void OrderIssue()
        {
            OrderComplete();
            Context context = new();
            var list = context.Orders.Where(i => i.Id == idOrder).ToList();

            label20.ForeColor = Color.Black;
            label21.ForeColor = Color.FromArgb(105, 101, 148);
            label22.ForeColor = Color.FromArgb(105, 101, 148);
            label23.ForeColor = Color.FromArgb(105, 101, 148);
            label24.ForeColor = Color.FromArgb(105, 101, 148);

            dateTimePicker1.Enabled = true;
            textBoxAvailabilityGuarantee.Enabled = true;
            textBoxGuaranteePeriod.Enabled = true;
            textBoxEndGuarantee.Enabled = true;
            textBoxGuaranteeLeft.Enabled = true;

            dateTimePicker1.Value = DateTime.Parse(list[0].DateIssue);

            if (list[0].Guarantee > 0)
            {
                if (DateTime.Now < DateTime.Parse(list[0].DateEndGuarantee))
                    textBoxAvailabilityGuarantee.Text = "Присутствует";
                else
                    textBoxAvailabilityGuarantee.Text = "Закончилась";
            }
            else
                textBoxAvailabilityGuarantee.Text = "Отсутствует";

            textBoxGuaranteePeriod.Text = list[0].Guarantee.ToString() + " мес.";
            textBoxEndGuarantee.Text = list[0].DateEndGuarantee;

            if (((int)(DateTime.Parse(list[0].DateEndGuarantee) - DateTime.Now).TotalDays) > 0)
                textBoxGuaranteeLeft.Text = ((int)(DateTime.Parse(list[0].DateEndGuarantee) - DateTime.Now).TotalDays).ToString() + " дн.";
            else
                textBoxGuaranteeLeft.Text = "Закончилась";

        }

        private void LinkLabelMaster_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddMaster addMaster = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addMaster.ShowDialog();
            UpdateComboBox(0);
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

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Context context = new();
            int id = Convert.ToInt32(textBoxIdOrder.Text);
            var list = context.Orders.Where(a => a.Id == id).ToList();
            string foundProblem = "";
            int priceRepair = 0;
            string dateIssue = "";
            string dateEndGuarantee = "";

            switch (statusOrder)
            {
                case "Completed":
                    foundProblem = textBoxFoundProblem.Text;
                    priceRepair = Convert.ToInt32(textBoxPriceRepair.Text);
                    break;
                case "GuaranteeIssue":
                    foundProblem = textBoxFoundProblem.Text;
                    priceRepair = Convert.ToInt32(textBoxPriceRepair.Text);
                    dateIssue = dateTimePicker1.Value.ToString();
                    dateEndGuarantee = (dateTimePicker1.Value.AddMonths(list[0].Guarantee)).ToString();
                    break;
                case "Archive":
                    foundProblem = textBoxFoundProblem.Text;
                    priceRepair = Convert.ToInt32(textBoxPriceRepair.Text);
                    dateIssue = dateTimePicker1.Value.ToString();
                    dateEndGuarantee = (dateTimePicker1.Value.AddMonths(list[0].Guarantee)).ToString();
                    break;
            }

            CRUD.ChangeOrder(id,
                list[0].ClientId,
                context.Masters.Where(a => a.NameMaster == comboBoxMaster.Text).ToList()[0].Id,
                dateCreation.Text,
                list[0].DateCompleted,
                list[0].DateIssue,
                context.TypeTechnices.Where(a => a.NameTypeTechnic == comboBoxDevice.Text).ToList()[0].Id,
                context.BrandTechnices.Where(a => a.NameBrandTechnic == comboBoxBrand.Text).ToList()[0].Id,
                textBoxModel.Text,
                textBoxFactoryNumber.Text,
                textBoxEquipment.Text,
                textBoxDiagnosis.Text,
                textBoxNote.Text,
                checkBoxUrgentRepair.Checked,
                list[0].InProgress,
                list[0].Guarantee,
                list[0].DateEndGuarantee,
                list[0].Deleted,
                list[0].ReturnUnderGuarantee,
                list[0].Issue,
                list[0].PriceRepair,
                list[0].FoundProblem);
            this.Close();
        }

        private void TextBoxPriceRepair_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 13)
                e.Handled = true;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Context context = new();
            var list = context.Orders.Where(i => i.Id == idOrder).Select(a => new { 
                a.DateCompleted,
                a.Guarantee,
                a.DateIssue
            }).ToList();

            if (dateTimePicker1.Value < DateTime.Parse(list[0].DateCompleted))
                dateTimePicker1.Value = DateTime.Parse(list[0].DateCompleted);

            textBoxEndGuarantee.Text = (dateTimePicker1.Value.AddMonths(list[0].Guarantee)).ToShortDateString();
            if (((int)(DateTime.Parse(textBoxEndGuarantee.Text) - DateTime.Now).TotalDays) > 0)
                textBoxGuaranteeLeft.Text = ((int)(DateTime.Parse(textBoxEndGuarantee.Text) - DateTime.Now).TotalDays).ToString() + " дн.";
            else
                textBoxGuaranteeLeft.Text = "Закончилась";

            if (list[0].Guarantee > 0)
            {
                if (DateTime.Now < DateTime.Parse(textBoxEndGuarantee.Text))
                    textBoxAvailabilityGuarantee.Text = "Присутствует";
                else
                    textBoxAvailabilityGuarantee.Text = "Закончилась";
            }
        }
    }
}
