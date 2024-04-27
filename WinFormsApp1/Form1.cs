using WinFormsApp1.Model;
using System.Data;
using System.Diagnostics;
using ClosedXML.Report;
using System.Data.SQLite;
using System.Net;
using FluentFTP;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public int idRow;
        public string status = "";
        public Form1()
        {
            InitializeComponent();
            InProgress();
            ToolStripEnabled();
        }

        private void UpdateTable()
        {
            dataGridView1.Columns[0].HeaderText = "№";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].HeaderText = "Дата приема";
            dataGridView1.Columns[1].Width = 110;
            dataGridView1.Columns[2].HeaderText = "Мастер";
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].HeaderText = "Тип аппарата";
            dataGridView1.Columns[3].Width = 160;
            dataGridView1.Columns[4].HeaderText = "Производитель";
            dataGridView1.Columns[4].Width = 180;
            dataGridView1.Columns[5].HeaderText = "Модель";
            dataGridView1.Columns[6].HeaderText = "Заказчик";
        }

        private void InProgress()
        {
            status = "InRepair";
            using Context context = new();
            var list = context.Orders.Where(i => i.InProgress == true && i.Deleted == false).Select(a => new
            {
                a.Id,
                a.DateCreation,
                a.Master.NameMaster,
                a.TypeTechnic.NameTypeTechnic,
                a.BrandTechnic.NameBrandTechnic,
                a.ModelTechnic,
                a.Client.NameClient,
                a.UrgentRepairs,
                a.Deleted,
                a.ReturnUnderGuarantee
            }).OrderByDescending(i => i.Id).ToList();
            dataGridView1.DataSource = Funcs.ToDataTable(list);
            UpdateTable();
            ChangeColorRows();
        }

        private void OrderСompleted()
        {
            status = "Completed";
            using Context context = new();
            var list = context.Orders.Where(i => i.InProgress == false && !i.Deleted && i.Issue == false).Select(a => new
            {
                a.Id,
                a.DateCreation,
                a.Master.NameMaster,
                a.TypeTechnic.NameTypeTechnic,
                a.BrandTechnic.NameBrandTechnic,
                a.ModelTechnic,
                a.Client.NameClient,
                a.UrgentRepairs,
                a.Deleted,
                a.ReturnUnderGuarantee
            }).OrderByDescending(i => i.Id).ToList();

            dataGridView1.DataSource = Funcs.ToDataTable(list);
            UpdateTable();
            ChangeColorRows();
        }

        private void OrderGuarantee()
        {
            status = "GuaranteeIssue";
            using Context context = new();

            var list = context.Orders.Where(i => i.Issue == true && !i.Deleted && i.Guarantee > 0).Select(a => new
            {
                a.Id,
                a.DateCreation,
                a.Master.NameMaster,
                a.TypeTechnic.NameTypeTechnic,
                a.BrandTechnic.NameBrandTechnic,
                a.ModelTechnic,
                a.Client.NameClient,
                a.UrgentRepairs,
                a.Deleted,
                a.ReturnUnderGuarantee,
                a.Guarantee,
                a.DateEndGuarantee
            }).OrderByDescending(i => i.Id).ToList();

            /*for(int i = 0; i < list.Count; i++)
            {
                if (DateTime.Parse(list[i].DateEndGuarantee) < DateTime.Now)
                    list.Remove(list[i]);
            }*/

            dataGridView1.DataSource = Funcs.ToDataTable(list);
            UpdateTable();
        }

        private void OrderArchive()
        {
            status = "Archive";
            using Context context = new();

            var list = context.Orders.Where(i => i.Issue == true && i.Guarantee == 0 && !i.Deleted).Select(a => new
            {
                a.Id,
                a.DateCreation,
                a.Master.NameMaster,
                a.TypeTechnic.NameTypeTechnic,
                a.BrandTechnic.NameBrandTechnic,
                a.ModelTechnic,
                a.Client.NameClient,
                a.UrgentRepairs,
                a.Deleted,
                a.ReturnUnderGuarantee,
                a.Guarantee,
                a.DateEndGuarantee
            }).OrderByDescending(i => i.Id).ToList();

            /*for (int i = 0; i < list.Count; i++)
            {
                if (DateTime.Parse(list[i].DateEndGuarantee) < DateTime.Now)
                    list.Remove(list[i]);
            }*/

            dataGridView1.DataSource = Funcs.ToDataTable(list);
            UpdateTable();
        }

        private void Trash()
        {
            status = "Trash";
            using Context context = new();
            var list = context.Orders.Where(i => i.Deleted == true).Select(a => new
            {
                a.Id,
                a.DateCreation,
                a.Master.NameMaster,
                a.TypeTechnic.NameTypeTechnic,
                a.BrandTechnic.NameBrandTechnic,
                a.ModelTechnic,
                a.Client.NameClient,
                a.UrgentRepairs,
                a.Deleted,
                a.ReturnUnderGuarantee
            }).OrderByDescending(i => i.Id).ToList();
            dataGridView1.DataSource = Funcs.ToDataTable(list);
            UpdateTable();
            ChangeColorRows();
        }

        private void FeaturesOrderItem()
        {
            int numberRow = dataGridView1.CurrentCell.RowIndex;
            idRow = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
            FeaturesOrder featuresOrder = new(idRow, status)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            featuresOrder.ShowDialog();
            FocusButton(status);
            switch (status)
            {
                case "InRepair":
                    InProgress();
                    break;
                case "Completed":
                    OrderСompleted();
                    break;
                case "GuaranteeIssue":
                    OrderGuarantee();
                    break;
                case "Archive":
                    OrderArchive();
                    break;
            }
            UpdateDB();
        }

        private void DetailsItem()
        {
            int numberRow = dataGridView1.CurrentCell.RowIndex;
            idRow = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
            AddDetails addDetails = new(idRow)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addDetails.ShowDialog();
            FocusButton(status);
        }

        private void DeleteOrder()
        {
            Context context = new();
            int numberRow = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
            var list = context.Orders.Where(a => a.Id == id).ToList();

            if (status == "Trash")
            {
                Warning warning = new()
                {
                    StartPosition = FormStartPosition.CenterParent,
                    LabelText = "Вы действительно хотите удалить аппарат из корзины?",
                    ButtonText = "Нет",
                    ButtonVisible = true
                };
                warning.ShowDialog();
                FocusButton(status);
                if (warning.pressBtnYes)
                {
                    CRUD.RemoveOrder(id);
                    CRUD.RemoveDetails(id);
                    Trash();
                }
            }
            else
            {
                Warning warning = new()
                {
                    StartPosition = FormStartPosition.CenterParent,
                    LabelText = "Вы действительно хотите переместить аппарат в корзину?",
                    ButtonText = "Нет",
                    ButtonVisible = true
                };
                warning.ShowDialog();
                FocusButton(status);
                if (warning.pressBtnYes)
                {
                    ChangeOrder(id, list[0].ClientId, list[0].MasterId, list[0].DateCreation,
                        list[0].DateCompleted, list[0].DateIssue, list[0].TypeTechnicId,
                        list[0].BrandTechnicId, list[0].ModelTechnic, list[0].FactoryNumber,
                        list[0].Equipment, list[0].Diagnosis, list[0].Note, list[0].UrgentRepairs,
                        list[0].InProgress, list[0].Guarantee, list[0].DateEndGuarantee, true,
                        list[0].ReturnUnderGuarantee, list[0].Issue, list[0].PriceRepair, list[0].FoundProblem);

                    switch (status)
                    {
                        case "InRepair":
                            InProgress();
                            break;
                        case "Completed":
                            OrderСompleted();
                            break;
                        case "GuaranteeIssue":
                            OrderGuarantee();
                            break;
                        case "Archive":
                            OrderArchive();
                            break;
                    }
                }
            }
            UpdateDB();
        }

        private void RecoveryOrder()
        {
            Context context = new();
            int numberRow = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
            var list = context.Orders.Where(a => a.Id == id).ToList();
            ChangeOrder(id, list[0].ClientId, list[0].MasterId, list[0].DateCreation,
                            list[0].DateCompleted, list[0].DateIssue, list[0].TypeTechnicId,
                            list[0].BrandTechnicId, list[0].ModelTechnic, list[0].FactoryNumber,
                            list[0].Equipment, list[0].Diagnosis, list[0].Note, list[0].UrgentRepairs,
                            list[0].InProgress, list[0].Guarantee, list[0].DateEndGuarantee, false,
                            list[0].ReturnUnderGuarantee, list[0].Issue, list[0].PriceRepair, list[0].FoundProblem);
            Trash();
            UpdateDB();
        }

        private void CompletedTag()
        {
            Context context = new();
            int numberRow = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
            var list = context.Orders.Where(a => a.Id == id).ToList();
            var listDetails = context.Details.Where(a => a.Id == id).ToList();
            bool enabledPrice = true;

            if (list[0].ReturnUnderGuarantee)
                enabledPrice = false;

            if (listDetails[0].NameDetails == null)
            {
                Warning warning = new()
                {
                    StartPosition = FormStartPosition.CenterParent,
                    LabelText = "Вы не использовали ни одной детали для ремонта данного устройства. " +
                    "\nХотите ли вы редактировать список деталей?",
                    ButtonText = "Нет",
                    ButtonVisible = true
                };
                warning.ShowDialog();
                FocusButton(status);

                if (warning.pressBtnYes)
                {
                    AddDetails addDetails = new(id)
                    {
                        StartPosition = FormStartPosition.CenterParent
                    };
                    addDetails.ShowDialog();
                    FocusButton(status);
                }
                else
                {
                    switch (status)
                    {
                        case "InRepair":
                            CompletedOrder completedOrder = new(id)
                            {
                                StartPosition = FormStartPosition.CenterParent,
                                EnabledPrice = enabledPrice
                            };
                            completedOrder.ShowDialog();
                            FocusButton(status);
                            if (completedOrder.save)
                            {
                                if (list[0].ReturnUnderGuarantee)
                                    ChangeOrder(id, list[0].ClientId, list[0].MasterId, list[0].DateCreation,
                                        completedOrder.DateComplete, list[0].DateIssue, list[0].TypeTechnicId,
                                        list[0].BrandTechnicId, list[0].ModelTechnic, list[0].FactoryNumber,
                                        list[0].Equipment, list[0].Diagnosis, list[0].Note, list[0].UrgentRepairs,
                                        false, list[0].Guarantee, list[0].DateEndGuarantee, list[0].Deleted,
                                        list[0].ReturnUnderGuarantee, list[0].Issue, list[0].PriceRepair, completedOrder.FoundProblem);
                                else
                                    ChangeOrder(id, list[0].ClientId, list[0].MasterId, list[0].DateCreation,
                                        completedOrder.DateComplete, list[0].DateIssue, list[0].TypeTechnicId,
                                        list[0].BrandTechnicId, list[0].ModelTechnic, list[0].FactoryNumber,
                                        list[0].Equipment, list[0].Diagnosis, list[0].Note, list[0].UrgentRepairs,
                                        false, list[0].Guarantee, list[0].DateEndGuarantee, list[0].Deleted,
                                        list[0].ReturnUnderGuarantee, list[0].Issue, completedOrder.PriceRepair, completedOrder.FoundProblem);


                                InProgress();
                            }
                            break;
                    }
                }
            }
            else
            {
                switch (status)
                {
                    case "InRepair":
                        CompletedOrder completedOrder = new(id)
                        {
                            StartPosition = FormStartPosition.CenterParent,
                            EnabledPrice = enabledPrice
                        };
                        completedOrder.ShowDialog();
                        FocusButton(status);
                        if (completedOrder.save)
                        {
                            if (list[0].ReturnUnderGuarantee)
                                ChangeOrder(id, list[0].ClientId, list[0].MasterId, list[0].DateCreation,
                                    completedOrder.DateComplete, list[0].DateIssue, list[0].TypeTechnicId,
                                    list[0].BrandTechnicId, list[0].ModelTechnic, list[0].FactoryNumber,
                                    list[0].Equipment, list[0].Diagnosis, list[0].Note, list[0].UrgentRepairs,
                                    false, list[0].Guarantee, list[0].DateEndGuarantee, list[0].Deleted,
                                    list[0].ReturnUnderGuarantee, list[0].Issue, list[0].PriceRepair, completedOrder.FoundProblem);
                            else
                                ChangeOrder(id, list[0].ClientId, list[0].MasterId, list[0].DateCreation,
                                    completedOrder.DateComplete, list[0].DateIssue, list[0].TypeTechnicId,
                                    list[0].BrandTechnicId, list[0].ModelTechnic, list[0].FactoryNumber,
                                    list[0].Equipment, list[0].Diagnosis, list[0].Note, list[0].UrgentRepairs,
                                    false, list[0].Guarantee, list[0].DateEndGuarantee, list[0].Deleted,
                                    list[0].ReturnUnderGuarantee, list[0].Issue, completedOrder.PriceRepair, completedOrder.FoundProblem);
                            InProgress();
                        }
                        break;
                }
            }
            UpdateDB();
        }

        private void IssueToClient()
        {
            Context context = new();
            int numberRow = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
            var list = context.Orders.Where(a => a.Id == id).ToList();

            switch (status)
            {
                case "Completed":
                    IssuingClient issuingClient = new(id)
                    {
                        StartPosition = FormStartPosition.CenterParent
                    };
                    issuingClient.ShowDialog();
                    FocusButton(status);
                    if (issuingClient.save)
                    {
                        ChangeOrder(id, list[0].ClientId, list[0].MasterId, list[0].DateCreation,
                            list[0].DateCompleted, issuingClient.DateIssue, list[0].TypeTechnicId,
                            list[0].BrandTechnicId, list[0].ModelTechnic, list[0].FactoryNumber,
                            list[0].Equipment, list[0].Diagnosis, list[0].Note, list[0].UrgentRepairs,
                            list[0].InProgress, issuingClient.GuaranteePeriod, issuingClient.DateEndGuarantee,
                            list[0].Deleted, list[0].ReturnUnderGuarantee, true, list[0].PriceRepair, list[0].FoundProblem);
                        OrderСompleted();
                    }
                    break;
            }
        }

        private void ReturnInRepair()
        {
            Context context = new();
            int numberRow = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
            var list = context.Orders.Where(a => a.Id == id).ToList();
            Warning warning = new()
            {
                StartPosition = FormStartPosition.CenterParent,
                LabelText = "Вы действительно хотите отправить аппарат в доработку?",
                ButtonText = "Нет",
                ButtonVisible = true
            };
            warning.ShowDialog();
            FocusButton(status);

            if (warning.pressBtnYes)
            {
                switch (status)
                {
                    case "Completed":
                        ChangeOrder(id, list[0].ClientId, list[0].MasterId, list[0].DateCreation,
                                    null, list[0].DateIssue, list[0].TypeTechnicId, list[0].BrandTechnicId,
                                    list[0].ModelTechnic, list[0].FactoryNumber, list[0].Equipment, list[0].Diagnosis,
                                    list[0].Note, list[0].UrgentRepairs, true, list[0].Guarantee, list[0].DateEndGuarantee,
                                    list[0].Deleted, list[0].ReturnUnderGuarantee, list[0].Issue, 0, null);
                        OrderСompleted();
                        break;
                }
            }
            UpdateDB();
        }

        private void ReturnGuarantee()
        {
            Context context = new();
            int numberRow = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
            var list = context.Orders.Where(a => a.Id == id).ToList();
            var listDetails = context.Details.Where(a => a.Id == id).ToList();
            Warning warning = new()
            {
                StartPosition = FormStartPosition.CenterParent,
                LabelText = "Вы действительно хотите вернуть аппарат по гарантии?",
                ButtonText = "Нет",
                ButtonVisible = true
            };
            warning.ShowDialog();
            FocusButton(status);

            if (warning.pressBtnYes)
            {
                switch (status)
                {
                    case "GuaranteeIssue":
                        ChangeOrder(id, list[0].ClientId, list[0].MasterId, list[0].DateCreation, null,
                            null, list[0].TypeTechnicId, list[0].BrandTechnicId, list[0].ModelTechnic,
                            list[0].FactoryNumber, list[0].Equipment, list[0].Diagnosis, list[0].Note,
                            list[0].UrgentRepairs, true, 0, null, list[0].Deleted, true, false, list[0].PriceRepair, null);
                        CRUD.ChangeDetails(id, null, null);
                        OrderGuarantee();
                        break;
                }
            }
            UpdateDB();
        }

        private void FeaturesClient()
        {
            string typeClient = "";
            Context context = new();
            int numberRow = dataGridView1.CurrentCell.RowIndex;
            int idOrder = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
            var list = context.Orders.Where(i => i.Id == idOrder).ToList();
            int idClient = list[0].ClientId;

            FeaturesClient featuresClient = new(idClient)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            featuresClient.ShowDialog();
            FocusButton(status);

            if (featuresClient.save)
            {
                if (featuresClient.NormalType)
                    typeClient = "normal";
                else if (featuresClient.WhiteType)
                    typeClient = "white";
                else if (featuresClient.BlackType)
                    typeClient = "black";

                CRUD.ChangeClient(idClient,
                    featuresClient.NameClient,
                    featuresClient.AdressClient,
                    featuresClient.WorkPhone,
                    featuresClient.HomePhone,
                    typeClient);
            }

            switch (status)
            {
                case "InRepair":
                    InProgress();
                    break;
                case "Completed":
                    OrderСompleted();
                    break;
                case "GuaranteeIssue":
                    OrderGuarantee();
                    break;
                case "Archive":
                    OrderArchive();
                    break;
                case "Trash":
                    Trash();
                    break;
            }
        }

        private void AddInWhitelist()
        {
            Context context = new();
            int numberRow = dataGridView1.CurrentCell.RowIndex;
            int idOrder = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
            var list = context.Orders.Where(i => i.Id == idOrder).ToList();
            int idClient = list[0].ClientId;
            var listClient = context.Clients.Where(i => i.Id == idClient).ToList();

            CRUD.ChangeClient(idClient,
                listClient[0].NameClient,
                listClient[0].Address,
                listClient[0].NumberPhoneWork,
                listClient[0].NumberPhoneHome,
                "white");
        }

        private void AddInBlacklist()
        {
            Context context = new();
            int numberRow = dataGridView1.CurrentCell.RowIndex;
            int idOrder = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
            var list = context.Orders.Where(i => i.Id == idOrder).ToList();
            int idClient = list[0].ClientId;
            var listClient = context.Clients.Where(i => i.Id == idClient).ToList();

            CRUD.ChangeClient(idClient,
                listClient[0].NameClient,
                listClient[0].Address,
                listClient[0].NumberPhoneWork,
                listClient[0].NumberPhoneHome,
                "black");
        }

        private void RemoveMarks()
        {
            Context context = new();
            int numberRow = dataGridView1.CurrentCell.RowIndex;
            int idOrder = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
            var list = context.Orders.Where(i => i.Id == idOrder).ToList();
            int idClient = list[0].ClientId;
            var listClient = context.Clients.Where(i => i.Id == idClient).ToList();

            CRUD.ChangeClient(idClient,
                listClient[0].NameClient,
                listClient[0].Address,
                listClient[0].NumberPhoneWork,
                listClient[0].NumberPhoneHome,
                "normal");
        }

        private static void ChangeOrder(int id, int clientId, int masterId, string? dateCreation,
            string? dateCompleted, string? dateIssue, int typeTechnicId, int brandTechnicId,
            string? modelTechnic, string? factoryNumber, string? equipment, string? diagnosis,
            string? note, bool urgentRepair, bool inProgress, int guarantee,
            string? dateEndGuarantee, bool deleted, bool returnUnderGuarantee, bool issue,
            int priceRepair, string? foundProblem)
        {
            CRUD.ChangeOrder(id,
                       clientId,
                       masterId,
                       dateCreation,
                       dateCompleted,
                       dateIssue,
                       typeTechnicId,
                       brandTechnicId,
                       modelTechnic,
                       factoryNumber,
                       equipment,
                       diagnosis,
                       note,
                       urgentRepair,
                       inProgress,
                       guarantee,
                       dateEndGuarantee,
                       deleted,
                       returnUnderGuarantee,
                       issue,
                       priceRepair,
                       foundProblem);
        }

        private void ButtonInProgress_Click(object sender, EventArgs e)
        {
            InProgress();
            ToolStripEnabled();
        }

        private void ButtonCompleted_Click(object sender, EventArgs e)
        {
            OrderСompleted();
            ToolStripEnabled();
        }

        private void ButtonGuarantee_Click(object sender, EventArgs e)
        {
            OrderGuarantee();
            ToolStripEnabled();
        }

        private void ButtonArchive_Click(object sender, EventArgs e)
        {
            OrderArchive();
            ToolStripEnabled();
        }

        private void ButtonTrash_Click(object sender, EventArgs e)
        {
            Trash();
            ToolStripEnabled();
        }

        private void ChangeColorRows()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[9].Value)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Red;
                }
                else if ((bool)dataGridView1.Rows[i].Cells[7].Value)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.IndianRed;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.IndianRed;
                }
                else
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void ToolStripEnabled()
        {
            switch (status)
            {
                case "InRepair":
                    buttonDetails.Enabled = true;
                    buttonDelete.Enabled = true;
                    buttonRecoveryOrder.Enabled = false;
                    buttonCompletedTag.Enabled = true;
                    buttonIssue.Enabled = false;
                    buttonReturnInRepair.Enabled = false;
                    buttonReturnGuarantee.Enabled = false;
                    buttonFeaturesOrder.Enabled = true;
                    break;
                case "Completed":
                    buttonDetails.Enabled = true;
                    buttonDelete.Enabled = true;
                    buttonRecoveryOrder.Enabled = false;
                    buttonCompletedTag.Enabled = false;
                    buttonIssue.Enabled = true;
                    buttonReturnInRepair.Enabled = true;
                    buttonReturnGuarantee.Enabled = false;
                    buttonFeaturesOrder.Enabled = true;
                    break;
                case "GuaranteeIssue":
                    buttonDetails.Enabled = true;
                    buttonDelete.Enabled = true;
                    buttonRecoveryOrder.Enabled = false;
                    buttonCompletedTag.Enabled = false;
                    buttonIssue.Enabled = false;
                    buttonReturnInRepair.Enabled = false;
                    buttonReturnGuarantee.Enabled = true;
                    buttonFeaturesOrder.Enabled = true;
                    break;
                case "Archive":
                    buttonDetails.Enabled = true;
                    buttonDelete.Enabled = true;
                    buttonRecoveryOrder.Enabled = false;
                    buttonCompletedTag.Enabled = false;
                    buttonIssue.Enabled = false;
                    buttonReturnInRepair.Enabled = false;
                    buttonReturnGuarantee.Enabled = false;
                    buttonFeaturesOrder.Enabled = true;
                    break;
                case "Trash":
                    buttonDetails.Enabled = false;
                    buttonDelete.Enabled = true;
                    buttonRecoveryOrder.Enabled = true;
                    buttonCompletedTag.Enabled = false;
                    buttonIssue.Enabled = false;
                    buttonReturnInRepair.Enabled = false;
                    buttonReturnGuarantee.Enabled = false;
                    buttonFeaturesOrder.Enabled = false;
                    break;
            }
        }

        private void ContextButton2()
        {
            switch (status)
            {
                case "InRepair":
                    itemFeaturesOrder.Enabled = true;
                    itemDetails.Enabled = true;
                    itemDeleteOrder.Enabled = true;
                    itemRecoveryOrder.Enabled = false;
                    itemActionsOrder.Enabled = true;
                    itemOrderCompleted.Enabled = true;
                    itemOrderIssued.Enabled = false;
                    itemReturnToRevision.Enabled = false;
                    itemReturnUnderGuarantee.Enabled = false;
                    itemFeaturesClient.Enabled = true;
                    itemAddToWhitelist.Enabled = true;
                    itemAddToBlacklist.Enabled = true;
                    itemRemoveMarks.Enabled = true;
                    break;
                case "Completed":
                    itemFeaturesOrder.Enabled = true;
                    itemDetails.Enabled = true;
                    itemDeleteOrder.Enabled = true;
                    itemRecoveryOrder.Enabled = false;
                    itemActionsOrder.Enabled = true;
                    itemOrderCompleted.Enabled = false;
                    itemOrderIssued.Enabled = true;
                    itemReturnToRevision.Enabled = true;
                    itemReturnUnderGuarantee.Enabled = false;
                    itemFeaturesClient.Enabled = true;
                    itemAddToWhitelist.Enabled = true;
                    itemAddToBlacklist.Enabled = true;
                    itemRemoveMarks.Enabled = true;
                    break;
                case "GuaranteeIssue":
                    itemFeaturesOrder.Enabled = true;
                    itemDetails.Enabled = true;
                    itemDeleteOrder.Enabled = true;
                    itemRecoveryOrder.Enabled = false;
                    itemActionsOrder.Enabled = true;
                    itemOrderCompleted.Enabled = false;
                    itemOrderIssued.Enabled = false;
                    itemReturnToRevision.Enabled = false;
                    itemReturnUnderGuarantee.Enabled = true;
                    itemFeaturesClient.Enabled = true;
                    itemAddToWhitelist.Enabled = true;
                    itemAddToBlacklist.Enabled = true;
                    itemRemoveMarks.Enabled = true;
                    break;
                case "Archive":
                    itemFeaturesOrder.Enabled = true;
                    itemDetails.Enabled = true;
                    itemDeleteOrder.Enabled = true;
                    itemRecoveryOrder.Enabled = false;
                    itemActionsOrder.Enabled = false;
                    itemFeaturesClient.Enabled = true;
                    itemAddToWhitelist.Enabled = true;
                    itemAddToBlacklist.Enabled = true;
                    itemRemoveMarks.Enabled = true;
                    break;
                case "Trash":
                    itemFeaturesOrder.Enabled = false;
                    itemDetails.Enabled = false;
                    itemDeleteOrder.Enabled = true;
                    itemRecoveryOrder.Enabled = true;
                    itemActionsOrder.Enabled = false;
                    itemFeaturesClient.Enabled = true;
                    itemAddToWhitelist.Enabled = true;
                    itemAddToBlacklist.Enabled = true;
                    itemRemoveMarks.Enabled = true;
                    break;
            }
        }

        private void ContextButton3()
        {
            switch (status)
            {
                case "InRepair":
                    itemGetting.Enabled = true;
                    itemIssuing.Enabled = false;
                    break;
                case "Completed":
                    itemGetting.Enabled = true;
                    itemIssuing.Enabled = false;
                    break;
                case "GuaranteeIssue":
                    itemGetting.Enabled = true;
                    itemIssuing.Enabled = true;
                    break;
                case "Archive":
                    itemGetting.Enabled = true;
                    itemIssuing.Enabled = true;
                    break;
                case "Trash":
                    itemGetting.Enabled = false;
                    itemIssuing.Enabled = false;
                    break;
            }
        }

        private void DataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            ChangeColorRows();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //buttonInProgress.Focus();
        }


        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenu1.Show(MousePosition);
                switch (status)
                {
                    case "InRepair":
                        item1.Enabled = true;
                        item2.Enabled = true;
                        item3.Enabled = true;
                        item4.Enabled = false;
                        item5_1.Enabled = true;
                        item5_2.Enabled = false;
                        item5_3.Enabled = false;
                        item5_4.Enabled = false;
                        break;
                    case "Completed":
                        item1.Enabled = true;
                        item2.Enabled = true;
                        item3.Enabled = true;
                        item4.Enabled = false;
                        item5_1.Enabled = false;
                        item5_2.Enabled = true;
                        item5_3.Enabled = true;
                        item5_4.Enabled = false;
                        break;
                    case "GuaranteeIssue":
                        item1.Enabled = true;
                        item2.Enabled = true;
                        item3.Enabled = true;
                        item4.Enabled = false;
                        item5_1.Enabled = false;
                        item5_2.Enabled = false;
                        item5_3.Enabled = false;
                        item5_4.Enabled = true;
                        break;
                    case "Archive":
                        item1.Enabled = true;
                        item2.Enabled = true;
                        item3.Enabled = true;
                        item4.Enabled = false;
                        item5.Enabled = false;
                        break;
                    case "Trash":
                        item1.Enabled = false;
                        item2.Enabled = false;
                        item3.Enabled = true;
                        item4.Enabled = true;
                        item5.Enabled = false;
                        break;
                }
            }
        }
        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
            }
        }

        private void Item1_Click(object sender, EventArgs e)
        {
            FeaturesOrderItem();
        }

        private void Item2_Click(object sender, EventArgs e)
        {
            DetailsItem();
        }

        private void Item3_Click(object sender, EventArgs e)
        {
            DeleteOrder();
        }

        private void Item4_Click(object sender, EventArgs e)
        {
            RecoveryOrder();
        }

        private void Item5_1_Click(object sender, EventArgs e)
        {
            CompletedTag();
        }

        private void Item5_2_Click(object sender, EventArgs e)
        {
            IssueToClient();
        }

        private void Item5_3_Click(object sender, EventArgs e)
        {
            ReturnInRepair();
        }

        private void Item5_4_Click(object sender, EventArgs e)
        {
            ReturnGuarantee();
        }

        private void Item6_1_Click(object sender, EventArgs e)
        {
            FeaturesClient();
        }

        private void Item6_2_Click(object sender, EventArgs e)
        {

        }

        private void Item6_3_1_Click(object sender, EventArgs e)
        {
            AddInWhitelist();
        }

        private void Item6_3_2_Click(object sender, EventArgs e)
        {
            AddInBlacklist();
        }

        private void Item6_3_3_Click(object sender, EventArgs e)
        {
            RemoveMarks();
        }

        private void ButtonMasters_Click(object sender, EventArgs e)
        {
            AddMaster addMaster = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addMaster.ShowDialog();
            FocusButton(status);
        }

        private void ButtonDevice_Click(object sender, EventArgs e)
        {
            AddDevice addDevice = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addDevice.ShowDialog();
            FocusButton(status);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Warning warning = new()
            {
                StartPosition = FormStartPosition.CenterParent,
                LabelText = "Вы действительно хотите выйти из программы?",
                ButtonText = "Нет",
                ButtonVisible = true
            };
            warning.ShowDialog();
            FocusButton(status);

            if (warning.pressBtnYes)
                Application.Exit();
        }

        private void ButtonDetails_Click(object sender, EventArgs e)
        {
            DetailsItem();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteOrder();
        }

        private void ButtonRestoring_Click(object sender, EventArgs e)
        {
            RecoveryOrder();
        }

        private void ButtonCompletedTag_Click(object sender, EventArgs e)
        {
            CompletedTag();
        }

        private void ButtonIssue_Click(object sender, EventArgs e)
        {
            IssueToClient();
        }

        private void ButtonReturnInRepair_Click(object sender, EventArgs e)
        {
            ReturnInRepair();
        }

        private void ButtonReturnGuarantee_Click(object sender, EventArgs e)
        {
            ReturnGuarantee();
        }

        private void ButtonFeaturesOrder_Click(object sender, EventArgs e)
        {
            int numberRow = dataGridView1.CurrentCell.RowIndex;
            idRow = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
            FeaturesOrder featuresOrder = new(idRow, status)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            featuresOrder.ShowDialog();
            FocusButton(status);
            switch (status)
            {
                case "InRepair":
                    InProgress();
                    break;
                case "Completed":
                    OrderСompleted();
                    break;
                case "GuaranteeIssue":
                    OrderGuarantee();
                    break;
                case "Archive":
                    OrderArchive();
                    break;
            }
            UpdateDB();
        }

        private void ButtonFeaturesClient_Click(object sender, EventArgs e)
        {
            FeaturesClient();
        }

        private void LabelDataBase_MouseEnter(object sender, EventArgs e)
        {

            labelDataBase.BackColor = SystemColors.Highlight;
            labelDataBase.ForeColor = Color.White;
        }

        private void LabelDataBase_MouseLeave(object sender, EventArgs e)
        {
            labelDataBase.BackColor = SystemColors.Control;
            labelDataBase.ForeColor = Color.Black;
        }

        private void LabelWorkData_MouseEnter(object sender, EventArgs e)
        {
            labelWorkData.BackColor = SystemColors.Highlight;
            labelWorkData.ForeColor = Color.White;


        }

        private void LabelWorkData_MouseLeave(object sender, EventArgs e)
        {
            labelWorkData.BackColor = SystemColors.Control;
            labelWorkData.ForeColor = Color.Black;
        }

        private void LabelDocuments_MouseEnter(object sender, EventArgs e)
        {
            labelDocuments.BackColor = SystemColors.Highlight;
            labelDocuments.ForeColor = Color.White;
        }

        private void LabelDocuments_MouseLeave(object sender, EventArgs e)
        {
            labelDocuments.BackColor = SystemColors.Control;
            labelDocuments.ForeColor = Color.Black;
        }

        private void LabelReports_MouseEnter(object sender, EventArgs e)
        {
            labelReports.BackColor = SystemColors.Highlight;
            labelReports.ForeColor = Color.White;
        }

        private void LabelReports_MouseLeave(object sender, EventArgs e)
        {
            labelReports.BackColor = SystemColors.Control;
            labelReports.ForeColor = Color.Black;
        }

        private void LabelDataBase_Click(object sender, EventArgs e)
        {
            var screenPos = labelDataBase.PointToScreen(Point.Empty);
            contextButton1.Show(new Point(screenPos.X, screenPos.Y + labelDataBase.Height));
        }

        private void LabelWorkData_Click(object sender, EventArgs e)
        {
            ContextButton2();
            var screenPos = labelWorkData.PointToScreen(Point.Empty);
            contextButton2.Show(new Point(screenPos.X, screenPos.Y + labelWorkData.Height));
        }

        private void LabelDocuments_Click(object sender, EventArgs e)
        {
            ContextButton3();
            var screenPos = labelDocuments.PointToScreen(Point.Empty);
            contextButton3.Show(new Point(screenPos.X, screenPos.Y + labelDocuments.Height));
        }

        private void LabelReports_Click(object sender, EventArgs e)
        {
            var screenPos = labelReports.PointToScreen(Point.Empty);
            contextButton4.Show(new Point(screenPos.X, screenPos.Y + labelReports.Height));
        }

        private void ItemAddMasters_Click(object sender, EventArgs e)
        {
            AddMaster addMaster = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addMaster.ShowDialog(this);
            FocusButton(status);
        }

        private void ItemAddBrand_Click(object sender, EventArgs e)
        {
            AddBrand addBrand = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addBrand.ShowDialog();
            FocusButton(status);
        }
        private void ItemAddDevice_Click(object sender, EventArgs e)
        {
            AddDevice addDevice = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addDevice.ShowDialog();
            FocusButton(status);
        }

        private void ItemClients_Click(object sender, EventArgs e)
        {
            GuideClients guideClients = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            guideClients.ShowDialog();
            FocusButton(status);
        }

        private void ItemCopyBD_Click(object sender, EventArgs e)
        {
            try
            {
                using var location = new SQLiteConnection(@"Data Source=computerservice.db");
                using var destination = new SQLiteConnection(@"Data Source=./Res/computerservice.db");
                location.Open();
                destination.Open();
                location.BackupDatabase(destination, "main", "main", -1, null, 0);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void ItemUpdateService_Click(object sender, EventArgs e)
        {
            UpdateDB();
        }

        private void ItemExit_Click(object sender, EventArgs e)
        {
            Warning warning = new()
            {
                StartPosition = FormStartPosition.CenterParent,
                LabelText = "Вы действительно хотите выйти из программы?",
                ButtonText = "Нет",
                ButtonVisible = true
            };
            warning.ShowDialog();
            FocusButton(status);

            if (warning.pressBtnYes)
                Application.Exit();
        }

        private void ItemAddDeviceForRepair_Click(object sender, EventArgs e)
        {
            AddDeviceForRepair addDeviceForRepair = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addDeviceForRepair.ShowDialog();
            InProgress();
            UpdateDB();
            FocusButton(status);
        }

        private void ItemFeaturesOrder_Click(object sender, EventArgs e)
        {
            FeaturesOrderItem();
        }

        private void ItemDetails_Click(object sender, EventArgs e)
        {
            DetailsItem();
        }

        private void ItemDeleteOrder_Click(object sender, EventArgs e)
        {
            DeleteOrder();
        }

        private void ItemRecoveryOrder_Click(object sender, EventArgs e)
        {
            RecoveryOrder();
        }

        private void ItemOrderCompleted_Click(object sender, EventArgs e)
        {
            CompletedTag();
        }

        private void ItemOrderIssued_Click(object sender, EventArgs e)
        {
            IssueToClient();
        }

        private void ItemReturnToRevision_Click(object sender, EventArgs e)
        {
            ReturnInRepair();
        }

        private void ItemReturnUnderGuarantee_Click(object sender, EventArgs e)
        {
            ReturnGuarantee();
        }

        private void ItemFeaturesClient_Click(object sender, EventArgs e)
        {
            FeaturesClient();
        }

        private void ItemMessageToClient_Click(object sender, EventArgs e)
        {

        }

        private void ItemAddToWhitelist_Click(object sender, EventArgs e)
        {
            AddInWhitelist();
        }

        private void ItemAddToBlacklist_Click(object sender, EventArgs e)
        {
            AddInBlacklist();
        }

        private void ItemRemoveMarks_Click(object sender, EventArgs e)
        {
            RemoveMarks();
        }

        private void ItemSearchOrder_Click(object sender, EventArgs e)
        {

        }

        private void ItemSalary_Click(object sender, EventArgs e)
        {
            CalculatingEmployeeSalaries salary = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            salary.ShowDialog();
            FocusButton(status);
        }

        private void ItemGetting_Click(object sender, EventArgs e)
        {
            try
            {
                const string outputFile = @"Output\reportGetting.xlsx";
                var template = new XLTemplate(@"Templates\reportGetting.xlsx");

                using Context context = new();
                int numberRow = dataGridView1.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
                var list = context.Orders.Where(i => i.Id == id).Select(i => new
                {
                    i.Id,
                    i.Client.NameClient,
                    i.Client.Address,
                    i.Client.NumberPhoneHome,
                    i.Client.NumberPhoneWork,
                    i.TypeTechnic.NameTypeTechnic,
                    i.BrandTechnic.NameBrandTechnic,
                    i.ModelTechnic,
                    i.FactoryNumber,
                    i.Equipment,
                    i.Diagnosis,
                    i.Master.NameMaster,
                    i.DateCreation,
                }).ToList();

                template.AddVariable("Id", value: list[0].Id);
                template.AddVariable("DateNowDay", value: DateTime.Now.Day);
                template.AddVariable("DateNowMonth", NameMonth(DateTime.Now.Month));
                template.AddVariable("DateNowYear", value: DateTime.Now.Year);
                template.AddVariable("ClientName", value: list[0].NameClient);
                template.AddVariable("ClientAddress", value: list[0].Address);
                template.AddVariable("ClientHomePhone", value: list[0].NumberPhoneHome);
                template.AddVariable("ClientWorkPhone", value: list[0].NumberPhoneWork);
                template.AddVariable("TypeDevice", value: list[0].NameTypeTechnic);
                template.AddVariable("BrandDevice", value: list[0].NameBrandTechnic);
                template.AddVariable("ModelDevice", value: list[0].ModelTechnic);
                template.AddVariable("FactoryNumber", value: list[0].FactoryNumber);
                template.AddVariable("Equipment", value: list[0].Equipment);
                template.AddVariable("Diagnosis", value: list[0].Diagnosis);
                template.AddVariable("MasterName", value: list[0].NameMaster);
                template.AddVariable("DateCreationDay", value: DateTime.Parse(list[0].DateCreation).Day);
                template.AddVariable("DateCreationMonth", NameMonth(DateTime.Parse(list[0].DateCreation).Month));
                template.AddVariable("DateCreationYear", value: DateTime.Parse(list[0].DateCreation).Year);

                template.Generate();
                try
                {
                    template.SaveAs(outputFile);
                }
                catch (Exception)
                {
                    Warning warning = new()
                    {
                        StartPosition = FormStartPosition.CenterParent,
                        LabelText = "Закройте файл reportGetting.xlsx и повторите попытку!"
                    };
                    warning.ShowDialog();
                    FocusButton(status);
                }

                Process.Start(new ProcessStartInfo(outputFile) { UseShellExecute = true });
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void ItemIssuing_Click(object sender, EventArgs e)
        {
            try
            {
                const string outputFile = @"Output\reportIssuing.xlsx";
                var template = new XLTemplate(@"Templates\reportIssuing.xlsx");

                using Context context = new();
                int numberRow = dataGridView1.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
                var list = context.Orders.Where(i => i.Id == id).Select(i => new
                {
                    i.Id,
                    i.Client.NameClient,
                    i.Client.Address,
                    i.Client.NumberPhoneHome,
                    i.Client.NumberPhoneWork,
                    i.TypeTechnic.NameTypeTechnic,
                    i.BrandTechnic.NameBrandTechnic,
                    i.ModelTechnic,
                    i.FactoryNumber,
                    i.Equipment,
                    i.FoundProblem,
                    i.DateIssue,
                    i.PriceRepair,
                    i.Guarantee,
                    i.DateEndGuarantee

                }).ToList();

                var listDetails = context.Details.Where(i => i.Id == id).ToList();

                List<string> listNameS = [];
                List<int> listPriceS = [];
                int detailsSum = 0;

                if (listDetails[0].PriceDetails != null)
                {
                    listNameS = new(listDetails[0].NameDetails);
                    listPriceS = new(listDetails[0].PriceDetails);
                }

                for (int i = 0; i < listPriceS.Count; i++)
                {
                    detailsSum += listPriceS[i];
                }

                List<string> nameDetails = [];
                List<string> priceDetails = [];

                for (int i = 0; i < 12; i++)
                {
                    nameDetails.Add("NameDetails" + i);
                    priceDetails.Add("PriceDetails" + i);
                }

                template.AddVariable("Id", value: list[0].Id);
                template.AddVariable("DateNowDay", value: DateTime.Now.Day);
                template.AddVariable("DateNowMonth", NameMonth(DateTime.Now.Month));
                template.AddVariable("DateNowYear", value: DateTime.Now.Year);
                template.AddVariable("ClientName", value: list[0].NameClient);
                template.AddVariable("ClientAddress", value: list[0].Address);
                template.AddVariable("ClientHomePhone", value: list[0].NumberPhoneHome);
                template.AddVariable("ClientWorkPhone", value: list[0].NumberPhoneWork);
                template.AddVariable("TypeDevice", value: list[0].NameTypeTechnic);
                template.AddVariable("BrandDevice", value: list[0].NameBrandTechnic);
                template.AddVariable("ModelDevice", value: list[0].ModelTechnic);
                template.AddVariable("FactoryNumber", value: list[0].FactoryNumber);
                template.AddVariable("Equipment", value: list[0].Equipment);
                template.AddVariable("FoundProblem", value: list[0].FoundProblem);
                template.AddVariable("DateIssuingDay", value: DateTime.Parse(list[0].DateIssue).Day);
                template.AddVariable("DateIssuingMonth", NameMonth(DateTime.Parse(list[0].DateIssue).Month));
                template.AddVariable("DateIssuingYear", value: DateTime.Parse(list[0].DateIssue).Year);
                template.AddVariable("DetailsSumPrice", value: detailsSum);
                template.AddVariable("PriceRepair", value: list[0].PriceRepair);
                template.AddVariable("TotalPrice", value: (detailsSum + list[0].PriceRepair));
                template.AddVariable("Guarantee", value: list[0].Guarantee);
                template.AddVariable("DateEndGuarantee", value: list[0].DateEndGuarantee);
                for (int i = 0; i < nameDetails.Count; i++)
                {
                    if (i < listNameS.Count)
                    {
                        template.AddVariable(nameDetails[i], value: listNameS[i]);
                        template.AddVariable(priceDetails[i], value: listPriceS[i]);
                    }
                    else
                    {
                        template.AddVariable(nameDetails[i], value: null);
                        template.AddVariable(priceDetails[i], value: null);
                    }
                }
                template.Generate();
                try
                {
                    template.SaveAs(outputFile);
                }
                catch (Exception)
                {
                    Warning warning = new()
                    {
                        StartPosition = FormStartPosition.CenterParent,
                        LabelText = "Закройте файл reportIssuing.xlsx и повторите попытку!"
                    };
                    warning.ShowDialog();
                    FocusButton(status);
                }

                Process.Start(new ProcessStartInfo(outputFile) { UseShellExecute = true });
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ChangeColorRows();
        }

        public void FocusButton(string status)
        {
            switch (status)
            {
                case "InRepair":
                    buttonInProgress.Focus();
                    break;
                case "Completed":
                    buttonCompleted.Focus();
                    break;
                case "GuaranteeIssue":
                    buttonGuarantee.Focus();
                    break;
                case "Archive":
                    buttonArchive.Focus();
                    break;
                case "Trash":
                    buttonTrash.Focus();
                    break;
            }
        }

        public static string NameMonth(int numberMonth)
        {
            string nameMonth = "";
            switch (numberMonth)
            {
                case 1:
                    nameMonth = "январь";
                    break;
                case 2:
                    nameMonth = "февраль";
                    break;
                case 3:
                    nameMonth = "март";
                    break;
                case 4:
                    nameMonth = "апрель";
                    break;
                case 5:
                    nameMonth = "май";
                    break;
                case 6:
                    nameMonth = "июнь";
                    break;
                case 7:
                    nameMonth = "июль";
                    break;
                case 8:
                    nameMonth = "август";
                    break;
                case 9:
                    nameMonth = "сентябрь";
                    break;
                case 10:
                    nameMonth = "октябрь";
                    break;
                case 11:
                    nameMonth = "ноябрь";
                    break;
                case 12:
                    nameMonth = "декабрь";
                    break;
            }

            return nameMonth;
        }

        private static void CopyDBForService()
        {
            using var fdb = new FolderBrowserDialog();
            var srcFile = "computerservice.db";
            var destFile1 = "./Service/computerservice.db";

            File.Copy(srcFile, destFile1, true);
        }

        private static void UpdateDB()
        {
            CopyDBForService();


            try
            {
                FtpClient client = new()
                {
                    Host = "155.254.244.40",
                    Credentials = new NetworkCredential("lizaveta", "wYwu6@L?2mhUT2?")
                };
                client.Connect();

            
                client.UploadFile("./Service/computerservice.db", "www.webappdb.somee.com//computerservice.db");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            FocusButton(status);
        }
    }
}
