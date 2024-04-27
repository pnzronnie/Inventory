namespace WinFormsApp1
{
    partial class FeaturesOrder
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
            tabControl1 = new TabControl();
            tabPageOrder = new TabPage();
            textBoxNote = new TextBox();
            linkLabelBrand = new LinkLabel();
            linkLabelDevice = new LinkLabel();
            checkBoxUrgentRepair = new CheckBox();
            textBoxDiagnosis = new TextBox();
            textBoxEquipment = new TextBox();
            textBoxFactoryNumber = new TextBox();
            textBoxModel = new TextBox();
            comboBoxBrand = new ComboBox();
            comboBoxDevice = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dateCreation = new DateTimePicker();
            linkLabelMaster = new LinkLabel();
            comboBoxMaster = new ComboBox();
            label3 = new Label();
            textBoxStatus = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxIdOrder = new TextBox();
            tabPageClient = new TabPage();
            label25 = new Label();
            textBoxTypeClient = new TextBox();
            textBoxAddress = new TextBox();
            label19 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            textBoxWorkPhone = new TextBox();
            textBoxHomePhone = new TextBox();
            textBoxClientName = new TextBox();
            tabPageDeviceRepair = new TabPage();
            label18 = new Label();
            listBox1 = new ListBox();
            textBoxPriceRepair = new TextBox();
            textBoxFoundProblem = new TextBox();
            labelPriceRepair = new Label();
            labelFoundProblem = new Label();
            textBoxPriceDetails = new TextBox();
            textBoxCountDetails = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            tabPageGuarantee = new TabPage();
            textBoxGuaranteeLeft = new TextBox();
            textBoxEndGuarantee = new TextBox();
            textBoxGuaranteePeriod = new TextBox();
            textBoxAvailabilityGuarantee = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            buttonSave = new Button();
            buttonExit = new Button();
            tabControl1.SuspendLayout();
            tabPageOrder.SuspendLayout();
            tabPageClient.SuspendLayout();
            tabPageDeviceRepair.SuspendLayout();
            tabPageGuarantee.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageOrder);
            tabControl1.Controls.Add(tabPageClient);
            tabControl1.Controls.Add(tabPageDeviceRepair);
            tabControl1.Controls.Add(tabPageGuarantee);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(789, 637);
            tabControl1.TabIndex = 0;
            // 
            // tabPageOrder
            // 
            tabPageOrder.Controls.Add(textBoxNote);
            tabPageOrder.Controls.Add(linkLabelBrand);
            tabPageOrder.Controls.Add(linkLabelDevice);
            tabPageOrder.Controls.Add(checkBoxUrgentRepair);
            tabPageOrder.Controls.Add(textBoxDiagnosis);
            tabPageOrder.Controls.Add(textBoxEquipment);
            tabPageOrder.Controls.Add(textBoxFactoryNumber);
            tabPageOrder.Controls.Add(textBoxModel);
            tabPageOrder.Controls.Add(comboBoxBrand);
            tabPageOrder.Controls.Add(comboBoxDevice);
            tabPageOrder.Controls.Add(label11);
            tabPageOrder.Controls.Add(label10);
            tabPageOrder.Controls.Add(label9);
            tabPageOrder.Controls.Add(label8);
            tabPageOrder.Controls.Add(label7);
            tabPageOrder.Controls.Add(label6);
            tabPageOrder.Controls.Add(label5);
            tabPageOrder.Controls.Add(label4);
            tabPageOrder.Controls.Add(dateCreation);
            tabPageOrder.Controls.Add(linkLabelMaster);
            tabPageOrder.Controls.Add(comboBoxMaster);
            tabPageOrder.Controls.Add(label3);
            tabPageOrder.Controls.Add(textBoxStatus);
            tabPageOrder.Controls.Add(label2);
            tabPageOrder.Controls.Add(label1);
            tabPageOrder.Controls.Add(textBoxIdOrder);
            tabPageOrder.Location = new Point(4, 34);
            tabPageOrder.Name = "tabPageOrder";
            tabPageOrder.Padding = new Padding(3);
            tabPageOrder.Size = new Size(781, 599);
            tabPageOrder.TabIndex = 0;
            tabPageOrder.Text = "Информация о заказе";
            tabPageOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxNote
            // 
            textBoxNote.Location = new Point(270, 487);
            textBoxNote.Multiline = true;
            textBoxNote.Name = "textBoxNote";
            textBoxNote.Size = new Size(463, 101);
            textBoxNote.TabIndex = 27;
            // 
            // linkLabelBrand
            // 
            linkLabelBrand.AutoSize = true;
            linkLabelBrand.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabelBrand.Location = new Point(552, 267);
            linkLabelBrand.Name = "linkLabelBrand";
            linkLabelBrand.Size = new Size(211, 25);
            linkLabelBrand.TabIndex = 26;
            linkLabelBrand.TabStop = true;
            linkLabelBrand.Text = "Список производителей";
            linkLabelBrand.LinkClicked += LinkLabelBrand_LinkClicked;
            // 
            // linkLabelDevice
            // 
            linkLabelDevice.AutoSize = true;
            linkLabelDevice.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabelDevice.Location = new Point(552, 223);
            linkLabelDevice.Name = "linkLabelDevice";
            linkLabelDevice.Size = new Size(124, 25);
            linkLabelDevice.TabIndex = 25;
            linkLabelDevice.TabStop = true;
            linkLabelDevice.Text = "Список типов";
            linkLabelDevice.LinkClicked += LinkLabelDevice_LinkClicked;
            // 
            // checkBoxUrgentRepair
            // 
            checkBoxUrgentRepair.AutoSize = true;
            checkBoxUrgentRepair.Location = new Point(496, 320);
            checkBoxUrgentRepair.Name = "checkBoxUrgentRepair";
            checkBoxUrgentRepair.Size = new Size(180, 29);
            checkBoxUrgentRepair.TabIndex = 24;
            checkBoxUrgentRepair.Text = "Срочный ремонт";
            checkBoxUrgentRepair.UseVisualStyleBackColor = true;
            // 
            // textBoxDiagnosis
            // 
            textBoxDiagnosis.Location = new Point(270, 449);
            textBoxDiagnosis.Name = "textBoxDiagnosis";
            textBoxDiagnosis.Size = new Size(463, 31);
            textBoxDiagnosis.TabIndex = 21;
            // 
            // textBoxEquipment
            // 
            textBoxEquipment.Location = new Point(270, 412);
            textBoxEquipment.Name = "textBoxEquipment";
            textBoxEquipment.Size = new Size(463, 31);
            textBoxEquipment.TabIndex = 20;
            // 
            // textBoxFactoryNumber
            // 
            textBoxFactoryNumber.Location = new Point(270, 358);
            textBoxFactoryNumber.Name = "textBoxFactoryNumber";
            textBoxFactoryNumber.Size = new Size(171, 31);
            textBoxFactoryNumber.TabIndex = 19;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(270, 321);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(171, 31);
            textBoxModel.TabIndex = 18;
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.BackColor = Color.FromArgb(224, 224, 224);
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.Location = new Point(270, 259);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(266, 33);
            comboBoxBrand.TabIndex = 17;
            // 
            // comboBoxDevice
            // 
            comboBoxDevice.BackColor = Color.FromArgb(224, 224, 224);
            comboBoxDevice.FormattingEnabled = true;
            comboBoxDevice.Location = new Point(270, 220);
            comboBoxDevice.Name = "comboBoxDevice";
            comboBoxDevice.Size = new Size(266, 33);
            comboBoxDevice.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(139, 487);
            label11.Name = "label11";
            label11.Size = new Size(116, 25);
            label11.TabIndex = 15;
            label11.Text = "Примечание";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 452);
            label10.Name = "label10";
            label10.Size = new Size(232, 25);
            label10.TabIndex = 14;
            label10.Text = "Предварительный диагноз";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(126, 415);
            label9.Name = "label9";
            label9.Size = new Size(129, 25);
            label9.TabIndex = 13;
            label9.Text = "Комплектация";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(96, 361);
            label8.Name = "label8";
            label8.Size = new Size(159, 25);
            label8.TabIndex = 12;
            label8.Text = "Заводской номер";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(179, 324);
            label7.Name = "label7";
            label7.Size = new Size(76, 25);
            label7.TabIndex = 11;
            label7.Text = "Модель";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 262);
            label6.Name = "label6";
            label6.Size = new Size(200, 25);
            label6.TabIndex = 10;
            label6.Text = "Фирма-производитель";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 223);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 9;
            label5.Text = "Тип устройства";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 175);
            label4.Name = "label4";
            label4.Size = new Size(211, 25);
            label4.TabIndex = 8;
            label4.Text = "Дата принятия в ремонт";
            // 
            // dateCreation
            // 
            dateCreation.Format = DateTimePickerFormat.Short;
            dateCreation.Location = new Point(270, 170);
            dateCreation.Name = "dateCreation";
            dateCreation.Size = new Size(266, 31);
            dateCreation.TabIndex = 7;
            // 
            // linkLabelMaster
            // 
            linkLabelMaster.AutoSize = true;
            linkLabelMaster.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabelMaster.Location = new Point(496, 124);
            linkLabelMaster.Name = "linkLabelMaster";
            linkLabelMaster.Size = new Size(154, 25);
            linkLabelMaster.TabIndex = 6;
            linkLabelMaster.TabStop = true;
            linkLabelMaster.Text = "Список мастеров";
            linkLabelMaster.LinkClicked += LinkLabelMaster_LinkClicked;
            // 
            // comboBoxMaster
            // 
            comboBoxMaster.BackColor = Color.FromArgb(224, 224, 224);
            comboBoxMaster.FormattingEnabled = true;
            comboBoxMaster.Location = new Point(270, 119);
            comboBoxMaster.Name = "comboBoxMaster";
            comboBoxMaster.Size = new Size(210, 33);
            comboBoxMaster.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 122);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 4;
            label3.Text = "Мастер";
            // 
            // textBoxStatus
            // 
            textBoxStatus.BackColor = SystemColors.ButtonFace;
            textBoxStatus.Location = new Point(270, 73);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Size = new Size(266, 31);
            textBoxStatus.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(105, 101, 148);
            label2.Location = new Point(62, 76);
            label2.Name = "label2";
            label2.Size = new Size(193, 25);
            label2.TabIndex = 2;
            label2.Text = "Состояние устройства";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(105, 101, 148);
            label1.Location = new Point(95, 33);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 1;
            label1.Text = "Номер квитанции";
            // 
            // textBoxIdOrder
            // 
            textBoxIdOrder.BackColor = SystemColors.ButtonFace;
            textBoxIdOrder.Location = new Point(270, 30);
            textBoxIdOrder.Name = "textBoxIdOrder";
            textBoxIdOrder.ReadOnly = true;
            textBoxIdOrder.Size = new Size(150, 31);
            textBoxIdOrder.TabIndex = 0;
            // 
            // tabPageClient
            // 
            tabPageClient.Controls.Add(label25);
            tabPageClient.Controls.Add(textBoxTypeClient);
            tabPageClient.Controls.Add(textBoxAddress);
            tabPageClient.Controls.Add(label19);
            tabPageClient.Controls.Add(label14);
            tabPageClient.Controls.Add(label13);
            tabPageClient.Controls.Add(label12);
            tabPageClient.Controls.Add(textBoxWorkPhone);
            tabPageClient.Controls.Add(textBoxHomePhone);
            tabPageClient.Controls.Add(textBoxClientName);
            tabPageClient.Location = new Point(4, 34);
            tabPageClient.Name = "tabPageClient";
            tabPageClient.Padding = new Padding(3);
            tabPageClient.Size = new Size(781, 599);
            tabPageClient.TabIndex = 1;
            tabPageClient.Text = "Информация о клиенте";
            tabPageClient.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.FromArgb(105, 101, 148);
            label25.Location = new Point(48, 248);
            label25.Name = "label25";
            label25.Size = new Size(154, 25);
            label25.TabIndex = 9;
            label25.Text = "Качество клиента";
            // 
            // textBoxTypeClient
            // 
            textBoxTypeClient.BackColor = SystemColors.ButtonFace;
            textBoxTypeClient.Location = new Point(217, 245);
            textBoxTypeClient.Name = "textBoxTypeClient";
            textBoxTypeClient.ReadOnly = true;
            textBoxTypeClient.Size = new Size(253, 31);
            textBoxTypeClient.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = SystemColors.ButtonFace;
            textBoxAddress.Location = new Point(217, 76);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(534, 31);
            textBoxAddress.TabIndex = 7;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.FromArgb(105, 101, 148);
            label19.Location = new Point(140, 79);
            label19.Name = "label19";
            label19.Size = new Size(62, 25);
            label19.TabIndex = 6;
            label19.Text = "Адрес";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.FromArgb(105, 101, 148);
            label14.Location = new Point(85, 184);
            label14.Name = "label14";
            label14.Size = new Size(117, 25);
            label14.TabIndex = 5;
            label14.Text = "Раб. телефон";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.FromArgb(105, 101, 148);
            label13.Location = new Point(78, 150);
            label13.Name = "label13";
            label13.Size = new Size(124, 25);
            label13.TabIndex = 4;
            label13.Text = "Дом. телефон";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.FromArgb(105, 101, 148);
            label12.Location = new Point(64, 33);
            label12.Name = "label12";
            label12.Size = new Size(138, 25);
            label12.TabIndex = 3;
            label12.Text = "ФИО заказчика";
            // 
            // textBoxWorkPhone
            // 
            textBoxWorkPhone.BackColor = SystemColors.ButtonFace;
            textBoxWorkPhone.Location = new Point(217, 181);
            textBoxWorkPhone.Name = "textBoxWorkPhone";
            textBoxWorkPhone.ReadOnly = true;
            textBoxWorkPhone.Size = new Size(253, 31);
            textBoxWorkPhone.TabIndex = 2;
            // 
            // textBoxHomePhone
            // 
            textBoxHomePhone.BackColor = SystemColors.ButtonFace;
            textBoxHomePhone.Location = new Point(217, 144);
            textBoxHomePhone.Name = "textBoxHomePhone";
            textBoxHomePhone.ReadOnly = true;
            textBoxHomePhone.Size = new Size(253, 31);
            textBoxHomePhone.TabIndex = 1;
            // 
            // textBoxClientName
            // 
            textBoxClientName.BackColor = SystemColors.ButtonFace;
            textBoxClientName.Location = new Point(217, 30);
            textBoxClientName.Name = "textBoxClientName";
            textBoxClientName.ReadOnly = true;
            textBoxClientName.Size = new Size(253, 31);
            textBoxClientName.TabIndex = 0;
            // 
            // tabPageDeviceRepair
            // 
            tabPageDeviceRepair.Controls.Add(label18);
            tabPageDeviceRepair.Controls.Add(listBox1);
            tabPageDeviceRepair.Controls.Add(textBoxPriceRepair);
            tabPageDeviceRepair.Controls.Add(textBoxFoundProblem);
            tabPageDeviceRepair.Controls.Add(labelPriceRepair);
            tabPageDeviceRepair.Controls.Add(labelFoundProblem);
            tabPageDeviceRepair.Controls.Add(textBoxPriceDetails);
            tabPageDeviceRepair.Controls.Add(textBoxCountDetails);
            tabPageDeviceRepair.Controls.Add(label17);
            tabPageDeviceRepair.Controls.Add(label16);
            tabPageDeviceRepair.Controls.Add(label15);
            tabPageDeviceRepair.Location = new Point(4, 34);
            tabPageDeviceRepair.Name = "tabPageDeviceRepair";
            tabPageDeviceRepair.Padding = new Padding(3);
            tabPageDeviceRepair.Size = new Size(781, 599);
            tabPageDeviceRepair.TabIndex = 2;
            tabPageDeviceRepair.Text = "Ремонт аппарата";
            tabPageDeviceRepair.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.FromArgb(150, 150, 150);
            label18.Location = new Point(384, 427);
            label18.Name = "label18";
            label18.Size = new Size(46, 25);
            label18.TabIndex = 12;
            label18.Text = "руб.";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(270, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(432, 204);
            listBox1.TabIndex = 11;
            // 
            // textBoxPriceRepair
            // 
            textBoxPriceRepair.Enabled = false;
            textBoxPriceRepair.Location = new Point(270, 424);
            textBoxPriceRepair.Name = "textBoxPriceRepair";
            textBoxPriceRepair.Size = new Size(108, 31);
            textBoxPriceRepair.TabIndex = 9;
            textBoxPriceRepair.KeyPress += TextBoxPriceRepair_KeyPress;
            // 
            // textBoxFoundProblem
            // 
            textBoxFoundProblem.AllowDrop = true;
            textBoxFoundProblem.Enabled = false;
            textBoxFoundProblem.Location = new Point(270, 384);
            textBoxFoundProblem.Name = "textBoxFoundProblem";
            textBoxFoundProblem.Size = new Size(432, 31);
            textBoxFoundProblem.TabIndex = 8;
            // 
            // labelPriceRepair
            // 
            labelPriceRepair.AutoSize = true;
            labelPriceRepair.ForeColor = Color.FromArgb(150, 150, 150);
            labelPriceRepair.Location = new Point(127, 427);
            labelPriceRepair.Name = "labelPriceRepair";
            labelPriceRepair.Size = new Size(128, 25);
            labelPriceRepair.TabIndex = 7;
            labelPriceRepair.Text = "Цена ремонта";
            // 
            // labelFoundProblem
            // 
            labelFoundProblem.AutoSize = true;
            labelFoundProblem.ForeColor = Color.FromArgb(150, 150, 150);
            labelFoundProblem.Location = new Point(27, 387);
            labelFoundProblem.Name = "labelFoundProblem";
            labelFoundProblem.Size = new Size(228, 25);
            labelFoundProblem.TabIndex = 6;
            labelFoundProblem.Text = "Найденная неисправность";
            // 
            // textBoxPriceDetails
            // 
            textBoxPriceDetails.Location = new Point(270, 288);
            textBoxPriceDetails.Name = "textBoxPriceDetails";
            textBoxPriceDetails.ReadOnly = true;
            textBoxPriceDetails.Size = new Size(150, 31);
            textBoxPriceDetails.TabIndex = 5;
            // 
            // textBoxCountDetails
            // 
            textBoxCountDetails.Location = new Point(270, 249);
            textBoxCountDetails.Name = "textBoxCountDetails";
            textBoxCountDetails.ReadOnly = true;
            textBoxCountDetails.Size = new Size(150, 31);
            textBoxCountDetails.TabIndex = 4;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.FromArgb(105, 101, 148);
            label17.Location = new Point(24, 291);
            label17.Name = "label17";
            label17.Size = new Size(231, 25);
            label17.TabIndex = 2;
            label17.Text = "Суммарная цена за детали";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.FromArgb(105, 101, 148);
            label16.Location = new Point(80, 252);
            label16.Name = "label16";
            label16.Size = new Size(175, 25);
            label16.TabIndex = 1;
            label16.Text = "Количество деталей";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.FromArgb(105, 101, 148);
            label15.Location = new Point(97, 35);
            label15.Name = "label15";
            label15.Size = new Size(158, 25);
            label15.TabIndex = 0;
            label15.Text = "Детали на ремонт";
            // 
            // tabPageGuarantee
            // 
            tabPageGuarantee.Controls.Add(textBoxGuaranteeLeft);
            tabPageGuarantee.Controls.Add(textBoxEndGuarantee);
            tabPageGuarantee.Controls.Add(textBoxGuaranteePeriod);
            tabPageGuarantee.Controls.Add(textBoxAvailabilityGuarantee);
            tabPageGuarantee.Controls.Add(dateTimePicker1);
            tabPageGuarantee.Controls.Add(label24);
            tabPageGuarantee.Controls.Add(label23);
            tabPageGuarantee.Controls.Add(label22);
            tabPageGuarantee.Controls.Add(label21);
            tabPageGuarantee.Controls.Add(label20);
            tabPageGuarantee.Location = new Point(4, 34);
            tabPageGuarantee.Name = "tabPageGuarantee";
            tabPageGuarantee.Padding = new Padding(3);
            tabPageGuarantee.Size = new Size(781, 599);
            tabPageGuarantee.TabIndex = 3;
            tabPageGuarantee.Text = "Гарантия на устройство";
            tabPageGuarantee.UseVisualStyleBackColor = true;
            // 
            // textBoxGuaranteeLeft
            // 
            textBoxGuaranteeLeft.Enabled = false;
            textBoxGuaranteeLeft.Location = new Point(270, 191);
            textBoxGuaranteeLeft.Name = "textBoxGuaranteeLeft";
            textBoxGuaranteeLeft.ReadOnly = true;
            textBoxGuaranteeLeft.Size = new Size(140, 31);
            textBoxGuaranteeLeft.TabIndex = 9;
            // 
            // textBoxEndGuarantee
            // 
            textBoxEndGuarantee.Enabled = false;
            textBoxEndGuarantee.Location = new Point(270, 154);
            textBoxEndGuarantee.Name = "textBoxEndGuarantee";
            textBoxEndGuarantee.ReadOnly = true;
            textBoxEndGuarantee.Size = new Size(180, 31);
            textBoxEndGuarantee.TabIndex = 8;
            // 
            // textBoxGuaranteePeriod
            // 
            textBoxGuaranteePeriod.Enabled = false;
            textBoxGuaranteePeriod.Location = new Point(270, 117);
            textBoxGuaranteePeriod.Name = "textBoxGuaranteePeriod";
            textBoxGuaranteePeriod.ReadOnly = true;
            textBoxGuaranteePeriod.Size = new Size(220, 31);
            textBoxGuaranteePeriod.TabIndex = 7;
            // 
            // textBoxAvailabilityGuarantee
            // 
            textBoxAvailabilityGuarantee.Enabled = false;
            textBoxAvailabilityGuarantee.ForeColor = Color.Black;
            textBoxAvailabilityGuarantee.Location = new Point(270, 80);
            textBoxAvailabilityGuarantee.Name = "textBoxAvailabilityGuarantee";
            textBoxAvailabilityGuarantee.ReadOnly = true;
            textBoxAvailabilityGuarantee.Size = new Size(260, 31);
            textBoxAvailabilityGuarantee.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(270, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(153, 31);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.ForeColor = Color.FromArgb(150, 150, 150);
            label24.Location = new Point(48, 194);
            label24.Name = "label24";
            label24.Size = new Size(207, 25);
            label24.TabIndex = 4;
            label24.Text = "Осталось до окончания";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.FromArgb(150, 150, 150);
            label23.Location = new Point(29, 157);
            label23.Name = "label23";
            label23.Size = new Size(226, 25);
            label23.TabIndex = 3;
            label23.Text = "Срок окончания гарантии";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.FromArgb(150, 150, 150);
            label22.Location = new Point(36, 120);
            label22.Name = "label22";
            label22.Size = new Size(219, 25);
            label22.TabIndex = 2;
            label22.Text = "Срок гарантии в месяцах";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.FromArgb(150, 150, 150);
            label21.Location = new Point(95, 83);
            label21.Name = "label21";
            label21.Size = new Size(160, 25);
            label21.TabIndex = 1;
            label21.Text = "Наличие гарантии";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.FromArgb(150, 150, 150);
            label20.Location = new Point(60, 33);
            label20.Name = "label20";
            label20.Size = new Size(195, 25);
            label20.TabIndex = 0;
            label20.Text = "Дата выдачи аппарата";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(390, 656);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(194, 34);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(603, 656);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(194, 34);
            buttonExit.TabIndex = 27;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += ButtonExit_Click;
            // 
            // FeaturesOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 698);
            Controls.Add(buttonExit);
            Controls.Add(buttonSave);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FeaturesOrder";
            Text = "FeaturesOrder";
            tabControl1.ResumeLayout(false);
            tabPageOrder.ResumeLayout(false);
            tabPageOrder.PerformLayout();
            tabPageClient.ResumeLayout(false);
            tabPageClient.PerformLayout();
            tabPageDeviceRepair.ResumeLayout(false);
            tabPageDeviceRepair.PerformLayout();
            tabPageGuarantee.ResumeLayout(false);
            tabPageGuarantee.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageOrder;
        private TabPage tabPageClient;
        private TabPage tabPageDeviceRepair;
        private TabPage tabPageGuarantee;
        private Label label1;
        private TextBox textBoxIdOrder;
        private Label label4;
        private DateTimePicker dateCreation;
        private LinkLabel linkLabelMaster;
        private ComboBox comboBoxMaster;
        private Label label3;
        private TextBox textBoxStatus;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxBrand;
        private ComboBox comboBoxDevice;
        private Label label11;
        private Label label10;
        private Label label9;
        private LinkLabel linkLabelDevice;
        private CheckBox checkBoxUrgentRepair;
        private TextBox textBoxDiagnosis;
        private TextBox textBoxEquipment;
        private TextBox textBoxFactoryNumber;
        private TextBox textBoxModel;
        private LinkLabel linkLabelBrand;
        private Button buttonSave;
        private Button buttonExit;
        private Label label14;
        private Label label13;
        private Label label12;
        private TextBox textBoxWorkPhone;
        private TextBox textBoxHomePhone;
        private TextBox textBoxClientName;
        private Label label17;
        private Label label16;
        private Label label15;
        private TextBox textBoxPriceRepair;
        private TextBox textBoxFoundProblem;
        private Label labelPriceRepair;
        private Label labelFoundProblem;
        private TextBox textBoxPriceDetails;
        private TextBox textBoxCountDetails;
        private TextBox textBoxNote;
        private Label label20;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxAvailabilityGuarantee;
        private TextBox textBoxGuaranteeLeft;
        private TextBox textBoxEndGuarantee;
        private TextBox textBoxGuaranteePeriod;
        private ListBox listBox1;
        private Label label18;
        private TextBox textBoxAddress;
        private Label label19;
        private Label label25;
        private TextBox textBoxTypeClient;
    }
}