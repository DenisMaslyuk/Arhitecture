using BL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View1
{
    public partial class Form1 : Form
    {

        Logic logic = new Logic();
        public Form1()
        {
            
            InitializeComponent();
            UpdateGrid();
        }

        public void UpdateGrid()
        {
            GridEmp.DataSource = logic.getData().ToList();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var form = new AddEmps();
            form.IdLabelSet.Hide();
            form.IdLabel.Hide();
            if (form.ShowDialog() == DialogResult.OK)
            {
                logic.SetData(form.NameBox.Text, Int32.Parse(form.AgeBox.Text), Int32.Parse(form.SalaryBox.Text), form.PositionBox.Text);
            }

            UpdateGrid();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int id =Int32.Parse( GridEmp.Rows[GridEmp.CurrentRow.Index].Cells[0].Value.ToString());
            logic.DeleteData(id);
            UpdateGrid();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var form = new AddEmps();
            int idrows = GridEmp.CurrentRow.Index;
            form.IdLabelSet.Text = GridEmp.Rows[idrows].Cells[0].Value.ToString();
            form.NameBox.Text = GridEmp.Rows[idrows].Cells[1].Value.ToString();
            form.AgeBox.Text = GridEmp.Rows[idrows].Cells[2].Value.ToString();
            form.SalaryBox.Text = GridEmp.Rows[idrows].Cells[3].Value.ToString();
            form.PositionBox.Text = GridEmp.Rows[idrows].Cells[4].Value.ToString();
            if (form.ShowDialog() == DialogResult.OK)
            {
                logic.UpdateData(
                    Int32.Parse(form.IdLabelSet.Text), 
                    form.NameBox.Text, 
                    Int32.Parse(form.AgeBox.Text), 
                    Int32.Parse(form.SalaryBox.Text), 
                    form.PositionBox.Text);
            }

            UpdateGrid();
        }


        private void DapperBtn_Click(object sender, EventArgs e)
        {
            var form = new DapperForm();
            form.Show();
        }
    }
}
