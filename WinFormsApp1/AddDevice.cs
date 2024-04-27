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
    public partial class AddDevice : Form
    {
        private int idKey;
        public AddDevice()
        {
            InitializeComponent();
            UpdateTable();
        }

        private void BtnAddDevice_Click(object sender, EventArgs e)
        {
            EnterBrandForm enterBrandForm = new()
            {
                StartPosition = FormStartPosition.CenterParent,
                Text = "Добавить тип устройства"
            };
            enterBrandForm.ShowDialog();
            if (enterBrandForm.Add)
            {
                CRUD.AddAsyncTypeTechnic(idKey, enterBrandForm.ReturnText);
                UpdateTable();
            }
        }

        private void BtnChangeDevice_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int numberRow = dataGridView1.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
                EnterBrandForm enterBrandForm = new()
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Text = "Изменение типа устройства",
                    BtnText = "Изменить",
                    TextBoxText = dataGridView1.Rows[numberRow].Cells[1].Value.ToString()
                };
                enterBrandForm.ShowDialog();

                if (enterBrandForm.Add)
                {
                    CRUD.ChangeTypeTechnic(id, enterBrandForm.ReturnText);
                    UpdateTable();
                }
            }
        }

        private void BtnDeleteDevice_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int numberRow = dataGridView1.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
                CRUD.RemoveTypeTechnic(id);
                UpdateTable();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateTable()
        {
            using Context context = new();
            dataGridView1.DataSource = context.TypeTechnices.ToList();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Тип устройства";
            dataGridView1.Columns[1].Width = 340;
            if (context.TypeTechnices.Any())
            {
                idKey = context.TypeTechnices.OrderBy(i => i.Id).Last().Id;
                idKey++;
            }
            else { idKey = 1; }
        }
    }
}
