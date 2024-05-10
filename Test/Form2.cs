using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;
using System.Numerics;
using static System.Net.WebRequestMethods;

namespace Test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbName.Text) & !String.IsNullOrEmpty(tbLastName.Text) & !String.IsNullOrEmpty(tbPhoneNumber.Text) & !String.IsNullOrEmpty(tbOms.Text) & !String.IsNullOrEmpty(dtp.Value.ToString("d")))
            {
                Patient patient = new Patient(tbName.Text, tbLastName.Text, tbPatronymic.Text, dtp.Value.ToString("d"), tbPhoneNumber.Text, tbOms.Text);
                Globals.Repos.addPatient(patient);
                // Очистить поля ввода и вернуться на главную форму
                tbName.Text = "";
                tbLastName.Text = "";
                tbPatronymic.Text = "";
                tbPhoneNumber.Text = "";
                tbOms.Text = "";
                dtp.MaxDate = DateTime.Now.Date;
                dtp.Value = DateTime.Now.Date;
                label7.Visible = false;
                this.Close();
            }
            else label7.Visible = true;
        }

        private void tbOms_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ввод только цифр, пробела и backspace
            
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {  
                    e.Handled = true;
            }
            if (e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ввод только цифр, +,  пробела и backspace
            
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 32 || e.KeyChar == 8 || e.KeyChar == 43)
            {
                e.Handled = false;
            }
        }

        // Ввод только русских букв, пробела и backspace
        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 'А' || e.KeyChar > 'я')
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8 || e.KeyChar == 32)
            {
                e.Handled =false;

            }

        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 'А' || e.KeyChar > 'я')
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8 || e.KeyChar == 32)
            {
                e.Handled = false;

            }
        }

        private void tbPatronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 'А' || e.KeyChar > 'я')
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8 || e.KeyChar == 32)
            {
                e.Handled = false;

            }
        }
    }
}
