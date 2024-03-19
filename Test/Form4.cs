using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Repository;

namespace Test
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            tbCurrentFile.Text = openFileDialog1.FileName;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbPRO.Text) & !String.IsNullOrEmpty(tbKET.Text) & !String.IsNullOrEmpty(tbGLU.Text) & !String.IsNullOrEmpty(tbHGB.Text)& !String.IsNullOrEmpty(tbTemperature.Text) & !String.IsNullOrEmpty(tbArPressure.Text) & !String.IsNullOrEmpty(tbCurrentFile.Text))
            {
                LabAnalyzes labAnalyzes = new LabAnalyzes(Globals.id, tbPRO.Text, tbKET.Text, tbGLU.Text, tbHGB.Text);
                Globals.Repos.addLabAnalyzes(labAnalyzes);
           
                InstAnalyzes instAnalyzes = new InstAnalyzes(Globals.id,tbCurrentFile.Text, tbTemperature.Text, tbArPressure.Text);
                Globals.Repos.addInstAnalyzes(instAnalyzes);

                tbPRO.Text = "";
                tbKET.Text = "";
                tbGLU.Text = "";
                tbHGB.Text = "";
                tbTemperature.Text = "";
                tbArPressure.Text = "";
                tbCurrentFile.Text = "";
                label12.Visible = false;
                this.Close();
            }else label12.Visible = true;


        }
        // Ввод только цифр и точки
        private void tbPRO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
        }

        private void tbKET_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
        }

        private void tbGLU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
        }

        private void tbHGB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
        }

        private void tbTemperature_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
        }

        private void tbArPressure_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8 || e.KeyChar == 46 || e.KeyChar == 47)
            {
                e.Handled = false;
            }
        }
    }
}
