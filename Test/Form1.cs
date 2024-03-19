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

        private void Form1_Activated(object sender, EventArgs e)
        {
            DataSet ds = Globals.Repos.readPatients();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            DataSet labDs = Globals.Repos.readLabAnalyzes();
            dataGridView2.DataSource = labDs.Tables[0].DefaultView;

            DataSet instDs = Globals.Repos.readInstAnalyzes();
            dataGridView3.DataSource = instDs.Tables[0].DefaultView;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Globals.id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string CurrentName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string CurrentLastname = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string CurrentPatronymic = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            tbCurrentPatient.Text = $"{CurrentLastname} {CurrentName} {CurrentPatronymic}";

            DataSet labDs = Globals.Repos.readDataWithExamId(Globals.id,"LabAnalysis");
            dataGridView2.DataSource = labDs.Tables[0].DefaultView;

            DataSet instDs = Globals.Repos.readDataWithExamId(Globals.id, "InstAnalysis");
            dataGridView3.DataSource = instDs.Tables[0].DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Globals.Repos.deleteLabAnalyzes(Globals.id);
            Globals.Repos.deleteInstAnalyzes(Globals.id);
            Globals.Repos.deletePatient(Globals.id);

            DataSet ds = Globals.Repos.readPatients();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            DataSet labDs = Globals.Repos.readLabAnalyzes();
            dataGridView2.DataSource = labDs.Tables[0].DefaultView;

            DataSet instDs = Globals.Repos.readInstAnalyzes();
            dataGridView3.DataSource = instDs.Tables[0].DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Globals.id))
            {
            Globals.PatientEditForm.ShowDialog();
            }
        }

        private void BtnAddExam_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Globals.id))
            {
                Globals.ExamCreateForm.ShowDialog();
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Globals.examId = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            
        }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Globals.examId = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            
        }


        //Удаляет конкретное обследование
        public void deleteAndReadAnalyzes()
        {
            Globals.Repos.deleteAnalysisWithId(Globals.examId);
            Globals.examId = "";

            DataSet labDs = Globals.Repos.readLabAnalyzes();
            dataGridView2.DataSource = labDs.Tables[0].DefaultView;

            DataSet instDs = Globals.Repos.readInstAnalyzes();
            dataGridView3.DataSource = instDs.Tables[0].DefaultView;
        }

        private void tbnDeleteAnalyzes_Click(object sender, EventArgs e)
        {
            deleteAndReadAnalyzes();
        }
    }
}