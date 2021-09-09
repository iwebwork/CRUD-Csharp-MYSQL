using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testeCRUDOOP.Classes;
using MySql.Data.MySqlClient;

namespace testeCRUDOOP
{
    public partial class Form1 : Form
    {
        CRUD crud = new CRUD();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateSave_Click(object sender, EventArgs e)
        {
            //CREATE
            CREATE();
            READ();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // UPDATE
            UPDATE();
            READ();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // DELETE
            DELETE();
            READ();
        }

        // READ
        public void READ()
        {
            dataGridView1.DataSource = null;
            crud.Read_data();
            dataGridView1.DataSource = crud.dt;

        }

        // CREATE
        public void CREATE()
        {
            crud.nome = txtBoxCreateNome.Text;
            crud.tipo = txtBoxCreateTipo.Text;
            crud.Create_data();
        }

        //UPDATE
        public void UPDATE()
        {
            crud.nome = txtBoxCreateNome.Text;
            crud.tipo = txtBoxCreateTipo.Text;
            crud.id = lblId.Text;
            crud.Update_data();
        }

        //DELETE
        public void DELETE()
        {
            crud.id = lblId.Text;
            crud.Delete_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            READ();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // GET DATA
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    lblId.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtBoxUDNome.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txtBoxUDTipo.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());

                }
            }
            catch
            {
                MessageBox.Show("Não clique no cabeçalho");
            }
        }
    }
}
