using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotizApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Titel:", typeof(String));
            table.Columns.Add("Nachricht", typeof(String));
            dataGridView1.DataSource = table;
            dataGridView1.Columns["Nachricht"].Visible = false;
            dataGridView1.Columns["Titel:"].Width = 297;
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            txtTitel.Clear();
            txtNachricht.Clear();
        }
            
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitel.Text, txtNachricht.Text);
            txtTitel.Clear();
            txtNachricht.Clear();
        }

        private void btnLesen_Click(object sender, EventArgs e)
        {
                int index = dataGridView1.CurrentCell.RowIndex;

                if (index > -1)
                {
                    txtTitel.Text = table.Rows[index]["Titel:"].ToString();
                    txtNachricht.Text = table.Rows[index]["Nachricht"].ToString();
                }
        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            table.Rows[index].Delete();

        }
    }
}
