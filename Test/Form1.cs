using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using Repository;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("TestDB.db") == false)
            {
                SQLiteConnection.CreateFile("TestDB.db");
                Globals.Repos.createDB();
            }
            DataSet ds = Globals.Repos.readPatients();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.PatientAddForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            DataSet ds = Globals.Repos.readPatients();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Globals.id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Console.WriteLine(Globals.id); ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Globals.Repos.deletePatient(Globals.id);
            DataSet ds = Globals.Repos.readPatients();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Globals.id))
            {
            Globals.PatientEditForm.ShowDialog();
            }
        }
    }
}