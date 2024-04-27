using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            buttonInProgress = new Button();
            buttonCompleted = new Button();
            buttonGuarantee = new Button();
            buttonArchive = new Button();
            buttonTrash = new Button();
            contextMenu1 = new ContextMenuStrip(components);
            item1 = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            item2 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            item3 = new ToolStripMenuItem();
            item4 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            item5 = new ToolStripMenuItem();
            item5_1 = new ToolStripMenuItem();
            item5_2 = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            item5_3 = new ToolStripMenuItem();
            item5_4 = new ToolStripMenuItem();
            item6 = new ToolStripMenuItem();
            item6_1 = new ToolStripMenuItem();
            item6_2 = new ToolStripMenuItem();
            item6_3 = new ToolStripMenuItem();
            item6_3_1 = new ToolStripMenuItem();
            item6_3_2 = new ToolStripMenuItem();
            item6_3_3 = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            buttonMasters = new ToolStripButton();
            buttonDevice = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            buttonExit = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            buttonDetails = new ToolStripButton();
            buttonDelete = new ToolStripButton();
            buttonRecoveryOrder = new ToolStripButton();
            buttonCompletedTag = new ToolStripButton();
            buttonIssue = new ToolStripButton();
            buttonReturnInRepair = new ToolStripButton();
            buttonReturnGuarantee = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            buttonFeaturesOrder = new ToolStripButton();
            buttonFeaturesClient = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            labelDataBase = new Label();
            contextButton1 = new ContextMenuStrip(components);
            itemAddMasters = new ToolStripMenuItem();
            itemAddBrand = new ToolStripMenuItem();
            itemAddDevice = new ToolStripMenuItem();
            itemClients = new ToolStripMenuItem();
            toolStripSeparator9 = new ToolStripSeparator();
            itemCopyBD = new ToolStripMenuItem();
            itemUpdateService = new ToolStripMenuItem();
            toolStripSeparator10 = new ToolStripSeparator();
            itemExit = new ToolStripMenuItem();
            contextButton2 = new ContextMenuStrip(components);
            itemAddDeviceForRepair = new ToolStripMenuItem();
            itemFeaturesOrder = new ToolStripMenuItem();
            toolStripSeparator11 = new ToolStripSeparator();
            itemDetails = new ToolStripMenuItem();
            toolStripSeparator12 = new ToolStripSeparator();
            itemDeleteOrder = new ToolStripMenuItem();
            itemRecoveryOrder = new ToolStripMenuItem();
            toolStripSeparator13 = new ToolStripSeparator();
            itemActionsOrder = new ToolStripMenuItem();
            itemOrderCompleted = new ToolStripMenuItem();
            itemOrderIssued = new ToolStripMenuItem();
            toolStripSeparator14 = new ToolStripSeparator();
            itemReturnToRevision = new ToolStripMenuItem();
            itemReturnUnderGuarantee = new ToolStripMenuItem();
            itemActionsClient = new ToolStripMenuItem();
            itemFeaturesClient = new ToolStripMenuItem();
            toolStripSeparator15 = new ToolStripSeparator();
            itemMessageToClient = new ToolStripMenuItem();
            toolStripSeparator16 = new ToolStripSeparator();
            itemPriorityClient = new ToolStripMenuItem();
            itemAddToWhitelist = new ToolStripMenuItem();
            itemAddToBlacklist = new ToolStripMenuItem();
            itemRemoveMarks = new ToolStripMenuItem();
            toolStripSeparator17 = new ToolStripSeparator();
            itemSearchOrder = new ToolStripMenuItem();
            labelWorkData = new Label();
            labelDocuments = new Label();
            labelReports = new Label();
            contextButton3 = new ContextMenuStrip(components);
            itemGetting = new ToolStripMenuItem();
            itemIssuing = new ToolStripMenuItem();
            contextButton4 = new ContextMenuStrip(components);
            itemSalary = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenu1.SuspendLayout();
            toolStrip1.SuspendLayout();
            contextButton1.SuspendLayout();
            contextButton2.SuspendLayout();
            contextButton3.SuspendLayout();
            contextButton4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
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
            dataGridView1.Location = new Point(20, 89);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1014, 564);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellMouseClick += DataGridView1_CellMouseClick;
            dataGridView1.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick;
            dataGridView1.VisibleChanged += DataGridView1_VisibleChanged;
            dataGridView1.Click += DataGridView1_Click;
            dataGridView1.MouseClick += DataGridView1_MouseClick;
            // 
            // buttonInProgress
            // 
            buttonInProgress.BackColor = Color.Transparent;
            buttonInProgress.BackgroundImage = Properties.Resources.p1;
            buttonInProgress.BackgroundImageLayout = ImageLayout.Stretch;
            buttonInProgress.Location = new Point(1053, 89);
            buttonInProgress.Name = "buttonInProgress";
            buttonInProgress.Size = new Size(126, 108);
            buttonInProgress.TabIndex = 0;
            buttonInProgress.Text = "В ремонте";
            buttonInProgress.TextAlign = ContentAlignment.BottomCenter;
            buttonInProgress.UseVisualStyleBackColor = false;
            buttonInProgress.Click += ButtonInProgress_Click;
            // 
            // buttonCompleted
            // 
            buttonCompleted.BackgroundImage = Properties.Resources.p2;
            buttonCompleted.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCompleted.Location = new Point(1053, 203);
            buttonCompleted.Name = "buttonCompleted";
            buttonCompleted.Size = new Size(126, 108);
            buttonCompleted.TabIndex = 13;
            buttonCompleted.Text = "Сделанные";
            buttonCompleted.TextAlign = ContentAlignment.BottomCenter;
            buttonCompleted.UseVisualStyleBackColor = true;
            buttonCompleted.Click += ButtonCompleted_Click;
            // 
            // buttonGuarantee
            // 
            buttonGuarantee.BackgroundImage = Properties.Resources.p3;
            buttonGuarantee.BackgroundImageLayout = ImageLayout.Stretch;
            buttonGuarantee.Location = new Point(1053, 317);
            buttonGuarantee.Name = "buttonGuarantee";
            buttonGuarantee.Size = new Size(126, 108);
            buttonGuarantee.TabIndex = 14;
            buttonGuarantee.Text = "По гарантии";
            buttonGuarantee.TextAlign = ContentAlignment.BottomCenter;
            buttonGuarantee.UseVisualStyleBackColor = true;
            buttonGuarantee.Click += ButtonGuarantee_Click;
            // 
            // buttonArchive
            // 
            buttonArchive.BackgroundImage = Properties.Resources.p4;
            buttonArchive.BackgroundImageLayout = ImageLayout.Stretch;
            buttonArchive.Location = new Point(1053, 431);
            buttonArchive.Name = "buttonArchive";
            buttonArchive.Size = new Size(126, 108);
            buttonArchive.TabIndex = 15;
            buttonArchive.Text = "Архив";
            buttonArchive.TextAlign = ContentAlignment.BottomCenter;
            buttonArchive.UseVisualStyleBackColor = true;
            buttonArchive.Click += ButtonArchive_Click;
            // 
            // buttonTrash
            // 
            buttonTrash.BackgroundImage = Properties.Resources.p5;
            buttonTrash.BackgroundImageLayout = ImageLayout.Stretch;
            buttonTrash.Location = new Point(1053, 545);
            buttonTrash.Name = "buttonTrash";
            buttonTrash.Size = new Size(126, 108);
            buttonTrash.TabIndex = 16;
            buttonTrash.Text = "Корзина";
            buttonTrash.TextAlign = ContentAlignment.BottomCenter;
            buttonTrash.UseVisualStyleBackColor = true;
            buttonTrash.Click += ButtonTrash_Click;
            // 
            // contextMenu1
            // 
            contextMenu1.ImageScalingSize = new Size(24, 24);
            contextMenu1.Items.AddRange(new ToolStripItem[] { item1, toolStripSeparator4, item2, toolStripSeparator1, item3, item4, toolStripSeparator2, item5, item6 });
            contextMenu1.Name = "contextMenu";
            contextMenu1.Size = new Size(403, 214);
            // 
            // item1
            // 
            item1.BackgroundImageLayout = ImageLayout.Zoom;
            item1.Image = Properties.Resources.m1;
            item1.Name = "item1";
            item1.Size = new Size(402, 32);
            item1.Text = "Свойства аппарата";
            item1.Click += Item1_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(399, 6);
            // 
            // item2
            // 
            item2.Image = Properties.Resources.m2;
            item2.Name = "item2";
            item2.Size = new Size(402, 32);
            item2.Text = "Детали на ремонт аппарата";
            item2.Click += Item2_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(399, 6);
            // 
            // item3
            // 
            item3.Image = Properties.Resources.m3;
            item3.Name = "item3";
            item3.Size = new Size(402, 32);
            item3.Text = "Удаление аппарата";
            item3.Click += Item3_Click;
            // 
            // item4
            // 
            item4.Image = Properties.Resources.m4;
            item4.Name = "item4";
            item4.Size = new Size(402, 32);
            item4.Text = "Восстановление аппарата из корзины";
            item4.Click += Item4_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(399, 6);
            // 
            // item5
            // 
            item5.DropDownItems.AddRange(new ToolStripItem[] { item5_1, item5_2, toolStripSeparator3, item5_3, item5_4 });
            item5.Image = Properties.Resources.m5;
            item5.Name = "item5";
            item5.Size = new Size(402, 32);
            item5.Text = "Операции над аппаратом";
            // 
            // item5_1
            // 
            item5_1.Image = Properties.Resources.m5_1;
            item5_1.Name = "item5_1";
            item5_1.Size = new Size(473, 34);
            item5_1.Text = "Пометить аппарат как отремонтированный";
            item5_1.Click += Item5_1_Click;
            // 
            // item5_2
            // 
            item5_2.Image = Properties.Resources.m5_2;
            item5_2.Name = "item5_2";
            item5_2.Size = new Size(473, 34);
            item5_2.Text = "Выдать аппарат клиенту";
            item5_2.Click += Item5_2_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(470, 6);
            // 
            // item5_3
            // 
            item5_3.Image = Properties.Resources.m5_3;
            item5_3.Name = "item5_3";
            item5_3.Size = new Size(473, 34);
            item5_3.Text = "Возврат аппарата в доработку";
            item5_3.Click += Item5_3_Click;
            // 
            // item5_4
            // 
            item5_4.Image = Properties.Resources.m5_4;
            item5_4.Name = "item5_4";
            item5_4.Size = new Size(473, 34);
            item5_4.Text = "Возврат аппарата по гарантии";
            item5_4.Click += Item5_4_Click;
            // 
            // item6
            // 
            item6.DropDownItems.AddRange(new ToolStripItem[] { item6_1, item6_2, item6_3 });
            item6.Image = Properties.Resources.m6;
            item6.Name = "item6";
            item6.Size = new Size(402, 32);
            item6.Text = "Операции над клиентом";
            // 
            // item6_1
            // 
            item6_1.Image = Properties.Resources.m6_1;
            item6_1.Name = "item6_1";
            item6_1.Size = new Size(316, 34);
            item6_1.Text = "Свойства клиента";
            item6_1.Click += Item6_1_Click;
            // 
            // item6_2
            // 
            item6_2.Enabled = false;
            item6_2.Image = Properties.Resources.m6_2;
            item6_2.Name = "item6_2";
            item6_2.Size = new Size(316, 34);
            item6_2.Text = "Сообщение клиенту";
            item6_2.Click += Item6_2_Click;
            // 
            // item6_3
            // 
            item6_3.DropDownItems.AddRange(new ToolStripItem[] { item6_3_1, item6_3_2, item6_3_3 });
            item6_3.Image = Properties.Resources.m6_3;
            item6_3.Name = "item6_3";
            item6_3.Size = new Size(316, 34);
            item6_3.Text = "Приоритетность клиента";
            // 
            // item6_3_1
            // 
            item6_3_1.Image = Properties.Resources.m6_3_1;
            item6_3_1.Name = "item6_3_1";
            item6_3_1.Size = new Size(347, 34);
            item6_3_1.Text = "Добавить в белый список";
            item6_3_1.Click += Item6_3_1_Click;
            // 
            // item6_3_2
            // 
            item6_3_2.Image = Properties.Resources.m6_3_2;
            item6_3_2.Name = "item6_3_2";
            item6_3_2.Size = new Size(347, 34);
            item6_3_2.Text = "Добавить в черный список";
            item6_3_2.Click += Item6_3_2_Click;
            // 
            // item6_3_3
            // 
            item6_3_3.Image = Properties.Resources.m6_1;
            item6_3_3.Name = "item6_3_3";
            item6_3_3.Size = new Size(347, 34);
            item6_3_3.Text = "Снять с клиента все пометки";
            item6_3_3.Click += Item6_3_3_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { buttonMasters, buttonDevice, toolStripSeparator5, buttonExit, toolStripSeparator6, buttonDetails, buttonDelete, buttonRecoveryOrder, buttonCompletedTag, buttonIssue, buttonReturnInRepair, buttonReturnGuarantee, toolStripSeparator7, buttonFeaturesOrder, buttonFeaturesClient, toolStripSeparator8 });
            toolStrip1.Location = new Point(20, 53);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(450, 33);
            toolStrip1.TabIndex = 17;
            toolStrip1.Text = "toolStrip1";
            // 
            // buttonMasters
            // 
            buttonMasters.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonMasters.Image = Properties.Resources.main1;
            buttonMasters.ImageTransparentColor = Color.Magenta;
            buttonMasters.Name = "buttonMasters";
            buttonMasters.Size = new Size(34, 28);
            buttonMasters.Text = "Работа с данными о мастерах организации";
            buttonMasters.Click += ButtonMasters_Click;
            // 
            // buttonDevice
            // 
            buttonDevice.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonDevice.Image = Properties.Resources.main2;
            buttonDevice.ImageTransparentColor = Color.Magenta;
            buttonDevice.Name = "buttonDevice";
            buttonDevice.Size = new Size(34, 28);
            buttonDevice.Text = "Тип ремонтируемых устройств";
            buttonDevice.Click += ButtonDevice_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 33);
            // 
            // buttonExit
            // 
            buttonExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonExit.Image = Properties.Resources.main5;
            buttonExit.ImageTransparentColor = Color.Magenta;
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(34, 28);
            buttonExit.Text = "Выход из программы";
            buttonExit.Click += ButtonExit_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 33);
            // 
            // buttonDetails
            // 
            buttonDetails.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonDetails.Image = Properties.Resources.m2;
            buttonDetails.ImageTransparentColor = Color.Magenta;
            buttonDetails.Name = "buttonDetails";
            buttonDetails.Size = new Size(34, 28);
            buttonDetails.Text = "Детали, использованые в ремонте устройства";
            buttonDetails.Click += ButtonDetails_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonDelete.Image = Properties.Resources.m3;
            buttonDelete.ImageTransparentColor = Color.Magenta;
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(34, 28);
            buttonDelete.Text = "Удаление объекта из базы данных";
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // buttonRecoveryOrder
            // 
            buttonRecoveryOrder.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonRecoveryOrder.Image = Properties.Resources.m4;
            buttonRecoveryOrder.ImageTransparentColor = Color.Magenta;
            buttonRecoveryOrder.Name = "buttonRecoveryOrder";
            buttonRecoveryOrder.Size = new Size(34, 28);
            buttonRecoveryOrder.Text = "Восстановление удаленного ранее устройства";
            buttonRecoveryOrder.Click += ButtonRestoring_Click;
            // 
            // buttonCompletedTag
            // 
            buttonCompletedTag.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonCompletedTag.Image = Properties.Resources.m5_1;
            buttonCompletedTag.ImageTransparentColor = Color.Magenta;
            buttonCompletedTag.Name = "buttonCompletedTag";
            buttonCompletedTag.Size = new Size(34, 28);
            buttonCompletedTag.Text = "Пометка устройства как отремонтированного";
            buttonCompletedTag.Click += ButtonCompletedTag_Click;
            // 
            // buttonIssue
            // 
            buttonIssue.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonIssue.Image = Properties.Resources.m5_2;
            buttonIssue.ImageTransparentColor = Color.Magenta;
            buttonIssue.Name = "buttonIssue";
            buttonIssue.Size = new Size(34, 28);
            buttonIssue.Text = "Выдача устройства клиенту после ремонта";
            buttonIssue.Click += ButtonIssue_Click;
            // 
            // buttonReturnInRepair
            // 
            buttonReturnInRepair.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonReturnInRepair.Image = Properties.Resources.m5_3;
            buttonReturnInRepair.ImageTransparentColor = Color.Magenta;
            buttonReturnInRepair.Name = "buttonReturnInRepair";
            buttonReturnInRepair.Size = new Size(34, 28);
            buttonReturnInRepair.Text = "Возвращение аппарата в доработку";
            buttonReturnInRepair.Click += ButtonReturnInRepair_Click;
            // 
            // buttonReturnGuarantee
            // 
            buttonReturnGuarantee.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonReturnGuarantee.Image = Properties.Resources.m5_4;
            buttonReturnGuarantee.ImageTransparentColor = Color.Magenta;
            buttonReturnGuarantee.Name = "buttonReturnGuarantee";
            buttonReturnGuarantee.Size = new Size(34, 28);
            buttonReturnGuarantee.Text = "Возвращение устройтсва в ремонт по гарантии";
            buttonReturnGuarantee.Click += ButtonReturnGuarantee_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 33);
            // 
            // buttonFeaturesOrder
            // 
            buttonFeaturesOrder.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonFeaturesOrder.Image = Properties.Resources.m1;
            buttonFeaturesOrder.ImageTransparentColor = Color.Magenta;
            buttonFeaturesOrder.Name = "buttonFeaturesOrder";
            buttonFeaturesOrder.Size = new Size(34, 28);
            buttonFeaturesOrder.Text = "Свойства и параметры ремонтируемого объекта";
            buttonFeaturesOrder.Click += ButtonFeaturesOrder_Click;
            // 
            // buttonFeaturesClient
            // 
            buttonFeaturesClient.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonFeaturesClient.Image = Properties.Resources.m6;
            buttonFeaturesClient.ImageTransparentColor = Color.Magenta;
            buttonFeaturesClient.Name = "buttonFeaturesClient";
            buttonFeaturesClient.Size = new Size(34, 28);
            buttonFeaturesClient.Text = "Свойства клиента";
            buttonFeaturesClient.Click += ButtonFeaturesClient_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 33);
            // 
            // labelDataBase
            // 
            labelDataBase.BackColor = SystemColors.Control;
            labelDataBase.Location = new Point(23, 9);
            labelDataBase.Name = "labelDataBase";
            labelDataBase.Size = new Size(121, 34);
            labelDataBase.TabIndex = 18;
            labelDataBase.Text = "База данных";
            labelDataBase.TextAlign = ContentAlignment.MiddleCenter;
            labelDataBase.Click += LabelDataBase_Click;
            labelDataBase.MouseEnter += LabelDataBase_MouseEnter;
            labelDataBase.MouseLeave += LabelDataBase_MouseLeave;
            // 
            // contextButton1
            // 
            contextButton1.ImageScalingSize = new Size(24, 24);
            contextButton1.Items.AddRange(new ToolStripItem[] { itemAddMasters, itemAddBrand, itemAddDevice, itemClients, toolStripSeparator9, itemCopyBD, itemUpdateService, toolStripSeparator10, itemExit });
            contextButton1.Name = "contextMenuStripButton1";
            contextButton1.Size = new Size(372, 240);
            // 
            // itemAddMasters
            // 
            itemAddMasters.Image = Properties.Resources.main1;
            itemAddMasters.Name = "itemAddMasters";
            itemAddMasters.Size = new Size(371, 32);
            itemAddMasters.Text = "Работники организации";
            itemAddMasters.Click += ItemAddMasters_Click;
            // 
            // itemAddBrand
            // 
            itemAddBrand.Image = Properties.Resources.b1_2;
            itemAddBrand.Name = "itemAddBrand";
            itemAddBrand.Size = new Size(371, 32);
            itemAddBrand.Text = "Фирмы-производители устройств";
            itemAddBrand.Click += ItemAddBrand_Click;
            // 
            // itemAddDevice
            // 
            itemAddDevice.Image = Properties.Resources.main2;
            itemAddDevice.Name = "itemAddDevice";
            itemAddDevice.Size = new Size(371, 32);
            itemAddDevice.Text = "Типы устройств";
            itemAddDevice.Click += ItemAddDevice_Click;
            // 
            // itemClients
            // 
            itemClients.Image = Properties.Resources.men;
            itemClients.Name = "itemClients";
            itemClients.Size = new Size(371, 32);
            itemClients.Text = "Справочник клиентов";
            itemClients.Click += ItemClients_Click;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(368, 6);
            // 
            // itemCopyBD
            // 
            itemCopyBD.Image = Properties.Resources.main3_1;
            itemCopyBD.Name = "itemCopyBD";
            itemCopyBD.Size = new Size(371, 32);
            itemCopyBD.Text = "Сделать копию бд";
            itemCopyBD.Click += ItemCopyBD_Click;
            // 
            // itemUpdateService
            // 
            itemUpdateService.Image = Properties.Resources.main3_2;
            itemUpdateService.Name = "itemUpdateService";
            itemUpdateService.Size = new Size(371, 32);
            itemUpdateService.Text = "Обновление бд на сервере";
            itemUpdateService.Click += ItemUpdateService_Click;
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(368, 6);
            // 
            // itemExit
            // 
            itemExit.Image = Properties.Resources.main5;
            itemExit.Name = "itemExit";
            itemExit.Size = new Size(371, 32);
            itemExit.Text = "Выход из программы";
            itemExit.Click += ItemExit_Click;
            // 
            // contextButton2
            // 
            contextButton2.ImageScalingSize = new Size(24, 24);
            contextButton2.Items.AddRange(new ToolStripItem[] { itemAddDeviceForRepair, itemFeaturesOrder, toolStripSeparator11, itemDetails, toolStripSeparator12, itemDeleteOrder, itemRecoveryOrder, toolStripSeparator13, itemActionsOrder, itemActionsClient, toolStripSeparator17, itemSearchOrder });
            contextButton2.Name = "contextMenuStripButton2";
            contextButton2.Size = new Size(403, 284);
            // 
            // itemAddDeviceForRepair
            // 
            itemAddDeviceForRepair.Image = Properties.Resources.b2_1;
            itemAddDeviceForRepair.Name = "itemAddDeviceForRepair";
            itemAddDeviceForRepair.Size = new Size(402, 32);
            itemAddDeviceForRepair.Text = "Добавление аппарата";
            itemAddDeviceForRepair.Click += ItemAddDeviceForRepair_Click;
            // 
            // itemFeaturesOrder
            // 
            itemFeaturesOrder.Image = Properties.Resources.m1;
            itemFeaturesOrder.Name = "itemFeaturesOrder";
            itemFeaturesOrder.Size = new Size(402, 32);
            itemFeaturesOrder.Text = "Свойства аппарата";
            itemFeaturesOrder.Click += ItemFeaturesOrder_Click;
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new Size(399, 6);
            // 
            // itemDetails
            // 
            itemDetails.Image = Properties.Resources.m2;
            itemDetails.Name = "itemDetails";
            itemDetails.Size = new Size(402, 32);
            itemDetails.Text = "Детали на ремонт аппарата";
            itemDetails.Click += ItemDetails_Click;
            // 
            // toolStripSeparator12
            // 
            toolStripSeparator12.Name = "toolStripSeparator12";
            toolStripSeparator12.Size = new Size(399, 6);
            // 
            // itemDeleteOrder
            // 
            itemDeleteOrder.Image = Properties.Resources.m3;
            itemDeleteOrder.Name = "itemDeleteOrder";
            itemDeleteOrder.Size = new Size(402, 32);
            itemDeleteOrder.Text = "Удаление аппарата";
            itemDeleteOrder.Click += ItemDeleteOrder_Click;
            // 
            // itemRecoveryOrder
            // 
            itemRecoveryOrder.Image = Properties.Resources.m4;
            itemRecoveryOrder.Name = "itemRecoveryOrder";
            itemRecoveryOrder.Size = new Size(402, 32);
            itemRecoveryOrder.Text = "Восстановление аппарата из корзины";
            itemRecoveryOrder.Click += ItemRecoveryOrder_Click;
            // 
            // toolStripSeparator13
            // 
            toolStripSeparator13.Name = "toolStripSeparator13";
            toolStripSeparator13.Size = new Size(399, 6);
            // 
            // itemActionsOrder
            // 
            itemActionsOrder.DropDownItems.AddRange(new ToolStripItem[] { itemOrderCompleted, itemOrderIssued, toolStripSeparator14, itemReturnToRevision, itemReturnUnderGuarantee });
            itemActionsOrder.Image = Properties.Resources.m5;
            itemActionsOrder.Name = "itemActionsOrder";
            itemActionsOrder.Size = new Size(402, 32);
            itemActionsOrder.Text = "Операции над аппаратом";
            // 
            // itemOrderCompleted
            // 
            itemOrderCompleted.Image = Properties.Resources.m5_1;
            itemOrderCompleted.Name = "itemOrderCompleted";
            itemOrderCompleted.Size = new Size(473, 34);
            itemOrderCompleted.Text = "Пометить аппарат как отремонтированный";
            itemOrderCompleted.Click += ItemOrderCompleted_Click;
            // 
            // itemOrderIssued
            // 
            itemOrderIssued.Image = Properties.Resources.m5_2;
            itemOrderIssued.Name = "itemOrderIssued";
            itemOrderIssued.Size = new Size(473, 34);
            itemOrderIssued.Text = "Выдать аппарат клиенту";
            itemOrderIssued.Click += ItemOrderIssued_Click;
            // 
            // toolStripSeparator14
            // 
            toolStripSeparator14.Name = "toolStripSeparator14";
            toolStripSeparator14.Size = new Size(470, 6);
            // 
            // itemReturnToRevision
            // 
            itemReturnToRevision.Image = Properties.Resources.m5_3;
            itemReturnToRevision.Name = "itemReturnToRevision";
            itemReturnToRevision.Size = new Size(473, 34);
            itemReturnToRevision.Text = "Возврат аппарата в доработку";
            itemReturnToRevision.Click += ItemReturnToRevision_Click;
            // 
            // itemReturnUnderGuarantee
            // 
            itemReturnUnderGuarantee.Image = Properties.Resources.m5_4;
            itemReturnUnderGuarantee.Name = "itemReturnUnderGuarantee";
            itemReturnUnderGuarantee.Size = new Size(473, 34);
            itemReturnUnderGuarantee.Text = "Возврат аппарата по гарантии";
            itemReturnUnderGuarantee.Click += ItemReturnUnderGuarantee_Click;
            // 
            // itemActionsClient
            // 
            itemActionsClient.DropDownItems.AddRange(new ToolStripItem[] { itemFeaturesClient, toolStripSeparator15, itemMessageToClient, toolStripSeparator16, itemPriorityClient });
            itemActionsClient.Image = Properties.Resources.m6;
            itemActionsClient.Name = "itemActionsClient";
            itemActionsClient.Size = new Size(402, 32);
            itemActionsClient.Text = "Операции над клиентом";
            // 
            // itemFeaturesClient
            // 
            itemFeaturesClient.Image = Properties.Resources.m6_1;
            itemFeaturesClient.Name = "itemFeaturesClient";
            itemFeaturesClient.Size = new Size(278, 34);
            itemFeaturesClient.Text = "Свойства клиента";
            itemFeaturesClient.Click += ItemFeaturesClient_Click;
            // 
            // toolStripSeparator15
            // 
            toolStripSeparator15.Name = "toolStripSeparator15";
            toolStripSeparator15.Size = new Size(275, 6);
            // 
            // itemMessageToClient
            // 
            itemMessageToClient.Enabled = false;
            itemMessageToClient.Image = Properties.Resources.m6_2;
            itemMessageToClient.Name = "itemMessageToClient";
            itemMessageToClient.Size = new Size(278, 34);
            itemMessageToClient.Text = "Сообщение клиенту";
            itemMessageToClient.Click += ItemMessageToClient_Click;
            // 
            // toolStripSeparator16
            // 
            toolStripSeparator16.Name = "toolStripSeparator16";
            toolStripSeparator16.Size = new Size(275, 6);
            // 
            // itemPriorityClient
            // 
            itemPriorityClient.DropDownItems.AddRange(new ToolStripItem[] { itemAddToWhitelist, itemAddToBlacklist, itemRemoveMarks });
            itemPriorityClient.Image = Properties.Resources.m6_3;
            itemPriorityClient.Name = "itemPriorityClient";
            itemPriorityClient.Size = new Size(278, 34);
            itemPriorityClient.Text = "Приоритет клиента";
            // 
            // itemAddToWhitelist
            // 
            itemAddToWhitelist.Image = Properties.Resources.m6_3_1;
            itemAddToWhitelist.Name = "itemAddToWhitelist";
            itemAddToWhitelist.Size = new Size(406, 34);
            itemAddToWhitelist.Text = "Добавить клиента в \"белый список\"";
            itemAddToWhitelist.Click += ItemAddToWhitelist_Click;
            // 
            // itemAddToBlacklist
            // 
            itemAddToBlacklist.Image = Properties.Resources.m6_3_2;
            itemAddToBlacklist.Name = "itemAddToBlacklist";
            itemAddToBlacklist.Size = new Size(406, 34);
            itemAddToBlacklist.Text = "Добавить в \"черный список\"";
            itemAddToBlacklist.Click += ItemAddToBlacklist_Click;
            // 
            // itemRemoveMarks
            // 
            itemRemoveMarks.Image = Properties.Resources.m6_1;
            itemRemoveMarks.Name = "itemRemoveMarks";
            itemRemoveMarks.Size = new Size(406, 34);
            itemRemoveMarks.Text = "Снять все метки с клиента";
            itemRemoveMarks.Click += ItemRemoveMarks_Click;
            // 
            // toolStripSeparator17
            // 
            toolStripSeparator17.Name = "toolStripSeparator17";
            toolStripSeparator17.Size = new Size(399, 6);
            // 
            // itemSearchOrder
            // 
            itemSearchOrder.Enabled = false;
            itemSearchOrder.Image = Properties.Resources.b2_8;
            itemSearchOrder.Name = "itemSearchOrder";
            itemSearchOrder.Size = new Size(402, 32);
            itemSearchOrder.Text = "Поиск аппарата";
            itemSearchOrder.Click += ItemSearchOrder_Click;
            // 
            // labelWorkData
            // 
            labelWorkData.BackColor = SystemColors.Control;
            labelWorkData.Location = new Point(144, 9);
            labelWorkData.Name = "labelWorkData";
            labelWorkData.Size = new Size(168, 34);
            labelWorkData.TabIndex = 21;
            labelWorkData.Text = "Работа с данными";
            labelWorkData.TextAlign = ContentAlignment.MiddleCenter;
            labelWorkData.Click += LabelWorkData_Click;
            labelWorkData.MouseEnter += LabelWorkData_MouseEnter;
            labelWorkData.MouseLeave += LabelWorkData_MouseLeave;
            // 
            // labelDocuments
            // 
            labelDocuments.Location = new Point(312, 9);
            labelDocuments.Name = "labelDocuments";
            labelDocuments.Size = new Size(120, 34);
            labelDocuments.TabIndex = 22;
            labelDocuments.Text = "Документы";
            labelDocuments.TextAlign = ContentAlignment.MiddleCenter;
            labelDocuments.Click += LabelDocuments_Click;
            labelDocuments.MouseEnter += LabelDocuments_MouseEnter;
            labelDocuments.MouseLeave += LabelDocuments_MouseLeave;
            // 
            // labelReports
            // 
            labelReports.Location = new Point(438, 9);
            labelReports.Name = "labelReports";
            labelReports.Size = new Size(88, 34);
            labelReports.TabIndex = 23;
            labelReports.Text = "Отчеты";
            labelReports.TextAlign = ContentAlignment.MiddleCenter;
            labelReports.Click += LabelReports_Click;
            labelReports.MouseEnter += LabelReports_MouseEnter;
            labelReports.MouseLeave += LabelReports_MouseLeave;
            // 
            // contextButton3
            // 
            contextButton3.ImageScalingSize = new Size(24, 24);
            contextButton3.Items.AddRange(new ToolStripItem[] { itemGetting, itemIssuing });
            contextButton3.Name = "contextMenuStripButton3";
            contextButton3.Size = new Size(361, 68);
            // 
            // itemGetting
            // 
            itemGetting.Name = "itemGetting";
            itemGetting.Size = new Size(360, 32);
            itemGetting.Text = "Квитанция о получении в ремонт";
            itemGetting.Click += ItemGetting_Click;
            // 
            // itemIssuing
            // 
            itemIssuing.Name = "itemIssuing";
            itemIssuing.Size = new Size(360, 32);
            itemIssuing.Text = "Квитанция о выдачи аппарата";
            itemIssuing.Click += ItemIssuing_Click;
            // 
            // contextButton4
            // 
            contextButton4.ImageScalingSize = new Size(24, 24);
            contextButton4.Items.AddRange(new ToolStripItem[] { itemSalary });
            contextButton4.Name = "contextButton4";
            contextButton4.Size = new Size(219, 36);
            // 
            // itemSalary
            // 
            itemSalary.Name = "itemSalary";
            itemSalary.Size = new Size(218, 32);
            itemSalary.Text = "Расчет зарплаты";
            itemSalary.Click += ItemSalary_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 669);
            Controls.Add(labelReports);
            Controls.Add(labelDocuments);
            Controls.Add(labelWorkData);
            Controls.Add(labelDataBase);
            Controls.Add(toolStrip1);
            Controls.Add(buttonTrash);
            Controls.Add(buttonArchive);
            Controls.Add(buttonGuarantee);
            Controls.Add(buttonCompleted);
            Controls.Add(buttonInProgress);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DesktopAppDB";
            Activated += Form1_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenu1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextButton1.ResumeLayout(false);
            contextButton2.ResumeLayout(false);
            contextButton3.ResumeLayout(false);
            contextButton4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button buttonInProgress;
        private Button buttonCompleted;
        private Button buttonGuarantee;
        private Button buttonArchive;
        private Button buttonTrash;
        private ContextMenuStrip contextMenu1;
        private ToolStripMenuItem item1;
        private ToolStripMenuItem item2;
        private ToolStripMenuItem item3;
        private ToolStripMenuItem item4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem item5;
        private ToolStripMenuItem item6;
        private ToolStripMenuItem item5_1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem item5_2;
        private ToolStripMenuItem item5_3;
        private ToolStripMenuItem item5_4;
        private ToolStripMenuItem item6_1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem item6_2;
        private ToolStripMenuItem item6_3;
        private ToolStripMenuItem item6_3_1;
        private ToolStripMenuItem item6_3_2;
        private ToolStripMenuItem item6_3_3;
        private ToolStrip toolStrip1;
        private ToolStripButton buttonMasters;
        private ToolStripButton buttonDevice;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton buttonSettings;
        private ToolStripButton buttonPrinter;
        private ToolStripButton buttonExit;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton buttonDetails;
        private ToolStripButton buttonDelete;
        private ToolStripButton buttonRecoveryOrder;
        private ToolStripButton buttonCompletedTag;
        private ToolStripButton buttonIssue;
        private ToolStripButton buttonReturnInRepair;
        private ToolStripButton buttonReturnGuarantee;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton buttonFeaturesOrder;
        private ToolStripButton buttonFeaturesClient;
        private ToolStripSeparator toolStripSeparator8;
        private Label labelDataBase;
        private ContextMenuStrip contextButton1;
        private ToolStripMenuItem itemAddMasters;
        private ContextMenuStrip contextButton2;
        private ToolStripMenuItem itemAddDeviceForRepair;
        private Label labelWorkData;
        private Label labelDocuments;
        private Label labelReports;
        private ContextMenuStrip contextButton3;
        private ToolStripMenuItem itemAddBrand;
        private ToolStripMenuItem itemAddDevice;
        private ToolStripMenuItem itemClients;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem itemCopyBD;
        private ToolStripMenuItem itemPrinter;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem itemExit;
        private ToolStripMenuItem itemFeaturesOrder;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripMenuItem itemDetails;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripMenuItem itemDeleteOrder;
        private ToolStripMenuItem itemRecoveryOrder;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripMenuItem itemActionsClient;
        private ToolStripMenuItem itemActionsOrder;
        private ToolStripMenuItem itemOrderCompleted;
        private ToolStripMenuItem itemOrderIssued;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripMenuItem itemReturnToRevision;
        private ToolStripMenuItem itemReturnUnderGuarantee;
        private ToolStripMenuItem itemFeaturesClient;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripMenuItem itemMessageToClient;
        private ToolStripSeparator toolStripSeparator16;
        private ToolStripMenuItem itemPriorityClient;
        private ToolStripMenuItem itemAddToWhitelist;
        private ToolStripMenuItem itemAddToBlacklist;
        private ToolStripMenuItem itemRemoveMarks;
        private ToolStripSeparator toolStripSeparator17;
        private ToolStripMenuItem itemSearchOrder;
        private ContextMenuStrip contextButton4;
        private ToolStripMenuItem itemSalary;
        private ToolStripMenuItem itemGetting;
        private ToolStripMenuItem itemIssuing;
        private ToolStripMenuItem itemUpdateService;
    }
}
