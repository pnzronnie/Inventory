using System.Data;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class AddDetails : Form
    {
        public int idOrder;
        public AddDetails(int id)
        {
            InitializeComponent();
            idOrder = id;
            UpdateTable();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAddDetail_Click(object sender, EventArgs e)
        {
            Context context = new();
            EnterBrandForm enterBrandForm = new()
            {
                StartPosition = FormStartPosition.CenterParent,
                LabelVisible = true,
                PriceVisible = true,
                Text = "Детали на ремонт аппарата"
            };
            enterBrandForm.ShowDialog();

            
            var listName = context.Details.Where(i => i.Id == idOrder).Select(a => new { a.NameDetails }).ToList();
            var listPrice = context.Details.Where(i => i.Id == idOrder).Select(a => new { a.PriceDetails }).ToList();

            if (enterBrandForm.Add)
            {
                List<string> listNameS = [];
                List<int> listPriceS = [];
                if (listName[0].NameDetails != null)
                {
                    listNameS = new(listName[0].NameDetails);
                    listPriceS = new(listPrice[0].PriceDetails);
                }

                for (int i = 0; i < listName.Count; i++)
                {
                    if (enterBrandForm.ReturnText != null)
                    {
                        listNameS.Add(enterBrandForm.ReturnText);
                        listPriceS.Add(enterBrandForm.ReturnPrice);
                    }
                        
                }
                CRUD.ChangeDetails(idOrder, listNameS, listPriceS);
                UpdateTable();
            }
        }

        private void UpdateTable()
        {
            int summDetails = 0;
            using Context context = new();
            var listName = context.Details.Where(i => i.Id == idOrder).Select(a => new { a.NameDetails }).ToList();
            var listPrice = context.Details.Where(i => i.Id == idOrder).Select(a => new { a.PriceDetails }).ToList();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Name", "Название детали");
            dataGridView1.Columns.Add("Price", "Цена");
            dataGridView1.Columns[0].Width = 315;
            dataGridView1.Columns[1].Width = 100;

            if (listName[0].NameDetails != null) {
                List<string> listNameS = new(listName[0].NameDetails);
                List<int> listPriceS = new(listPrice[0].PriceDetails);
                for (int i = 0; i < listNameS.Count; i++)
                {
                    dataGridView1.Rows.Add(listNameS[i], listPriceS[i]);
                    summDetails += listPriceS[i];
                }
                labelCount.Text = listPriceS.Count.ToString() + " шт.";
                labelPrice.Text = summDetails.ToString() + " руб.";
            }
        }

        private void ButtonChangeDetail_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Context context = new();
                int numberRow = dataGridView1.CurrentCell.RowIndex;
                EnterBrandForm enterBrandForm = new()
                {
                    StartPosition = FormStartPosition.CenterParent,
                    LabelVisible = true,
                    PriceVisible = true,
                    Text = "Изменить данные",
                    BtnText = "Изменить",
                    TextBoxText = dataGridView1.Rows[numberRow].Cells[0].Value.ToString(),
                    TextBox2Text = dataGridView1.Rows[numberRow].Cells[1].Value.ToString()
                };
                enterBrandForm.ShowDialog();

                var listName = context.Details.Where(i => i.Id == idOrder).Select(a => new { a.NameDetails }).ToList();
                var listPrice = context.Details.Where(i => i.Id == idOrder).Select(a => new { a.PriceDetails }).ToList();

                List<string> listNameS = new(listName[0].NameDetails);
                List<int> listPriceS = new(listPrice[0].PriceDetails);

                listNameS[numberRow] = enterBrandForm.ReturnText;
                listPriceS[numberRow] = enterBrandForm.ReturnPrice;

                CRUD.ChangeDetails(idOrder, listNameS, listPriceS);
                UpdateTable();
            }
        }

        private void ButtonRemoveDetail_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Context context = new();
                int numberRow = dataGridView1.CurrentCell.RowIndex;

                var listName = context.Details.Where(i => i.Id == idOrder).Select(a => new { a.NameDetails }).ToList();
                var listPrice = context.Details.Where(i => i.Id == idOrder).Select(a => new { a.PriceDetails }).ToList();

                List<string> listNameS = new(listName[0].NameDetails);
                List<int> listPriceS = new(listPrice[0].PriceDetails);

                listNameS.RemoveAt(numberRow);
                listPriceS.RemoveAt(numberRow);

                CRUD.ChangeDetails(idOrder, listNameS, listPriceS);
                UpdateTable();
            }
        }
    }
}
