using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Model;

namespace View1
{
    public partial class DapperForm : Form
    {
        Logic logic = new Logic();
        public DapperForm()
        {
            InitializeComponent();
            UpdateGrid();
        }

        public void UpdateGrid()
        {
            DataGridDupper.Rows.Clear();
            foreach (var em in logic.getData())
            {
                string[] row = { em.Id.ToString(), em.Name, em.Age.ToString(), em.Salary.ToString(), em.Position };
                DataGridDupper.Rows.Add(row);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var form = new AddEmps();
            form.IdLabelSet.Hide();
            form.IdLabel.Hide();
            if (form.ShowDialog() == DialogResult.OK)
            {
                logic.SetDataDap(form.NameBox.Text, Int32.Parse(form.AgeBox.Text), Int32.Parse(form.SalaryBox.Text), form.PositionBox.Text);
            }

            UpdateGrid();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(DataGridDupper.Rows[DataGridDupper.CurrentRow.Index].Cells[0].Value.ToString());
            logic.DeleteDataDap(id);
            UpdateGrid();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var form = new AddEmps();
            int idrows = DataGridDupper.CurrentRow.Index;
            form.IdLabelSet.Text = DataGridDupper.Rows[idrows].Cells[0].Value.ToString();
            form.NameBox.Text = DataGridDupper.Rows[idrows].Cells[1].Value.ToString();
            form.AgeBox.Text = DataGridDupper.Rows[idrows].Cells[2].Value.ToString();
            form.SalaryBox.Text = DataGridDupper.Rows[idrows].Cells[3].Value.ToString();
            form.PositionBox.Text = DataGridDupper.Rows[idrows].Cells[4].Value.ToString();
            if (form.ShowDialog() == DialogResult.OK)
            {
                logic.UpdateDataDap(
                    Int32.Parse(form.IdLabelSet.Text),
                    form.NameBox.Text,
                    Int32.Parse(form.AgeBox.Text),
                    Int32.Parse(form.SalaryBox.Text),
                    form.PositionBox.Text);
            }

            UpdateGrid();
        }
    }
}
