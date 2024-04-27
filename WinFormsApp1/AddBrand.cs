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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class AddBrand : Form
    {
        private int idKey;
        public AddBrand()
        {
            InitializeComponent();
            UpdateTable();
        }

        private void BtnAddBrand_Click(object sender, EventArgs e)
        {
            EnterBrandForm enterBrandForm = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            enterBrandForm.ShowDialog();
            if (enterBrandForm.Add)
            {
                CRUD.AddAsyncBrandTechnic(idKey, enterBrandForm.ReturnText);
                UpdateTable();
            }
        }

        private void BtnChangeBrand_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int numberRow = dataGridView1.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
                EnterBrandForm enterBrandForm = new()
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Text = "Изменение названия фирмы",
                    BtnText = "Изменить",
                    TextBoxText = dataGridView1.Rows[numberRow].Cells[1].Value.ToString()
                };
                enterBrandForm.ShowDialog();

                if (enterBrandForm.Add)
                {
                    CRUD.ChangeBrandTechnic(id, enterBrandForm.ReturnText);
                    UpdateTable();
                }
            }
        }

        private void BtnDeleteBrand_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int numberRow = dataGridView1.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[numberRow].Cells[0].Value);
                CRUD.RemoveBrandTechnic(id);
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
            dataGridView1.DataSource = context.BrandTechnices.ToList();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[1].Width = 340;
            if (context.BrandTechnices.Any())
            {
                idKey = context.BrandTechnices.OrderBy(i => i.Id).Last().Id;
                idKey++;
            }
            else { idKey = 1; }
        }
    }
}
