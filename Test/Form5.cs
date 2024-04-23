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

namespace Test
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (btnConfirm.Text == "Подтвердить")
            {
                Globals.Repos.addSettings(tbFerrMin.Text, tbFerrMax.Text, tbSeIronMin.Text, tbSeIronMax.Text, tbHGBMin.Text, tbHGBMax.Text);

                tbFerrMin.Text = "";
                tbFerrMax.Text = "";
                tbSeIronMin.Text = "";
                tbSeIronMax.Text = "";
                tbHGBMin.Text = "";
                tbHGBMax.Text = "";
                this.Close();
            }
            else if (btnConfirm.Text == "Изменить")
            {
                Globals.Repos.updateSettings(tbFerrMin.Text, tbFerrMax.Text, tbSeIronMin.Text, tbSeIronMax.Text, tbHGBMin.Text, tbHGBMax.Text);

                tbFerrMin.Text = "";
                tbFerrMax.Text = "";
                tbSeIronMin.Text = "";
                tbSeIronMax.Text = "";
                tbHGBMin.Text = "";
                tbHGBMax.Text = "";
                this.Close();
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            btnConfirm.Text = "Подтвердить";
         (string[], string[], string[]) Values =  Globals.Repos.checkSettings();

            
                tbFerrMin.Text = Values.Item1[0];
                tbFerrMax.Text = Values.Item1[1];
                tbSeIronMin.Text = Values.Item2[0];
                tbSeIronMax.Text = Values.Item2[1];
                tbHGBMin.Text = Values.Item3[0];
                tbHGBMax.Text = Values.Item3[1];
            if (tbFerrMin.Text !="" || tbFerrMax.Text != ""|| tbSeIronMin.Text!="" || tbSeIronMax.Text != ""|| tbHGBMin.Text!=""|| tbHGBMax.Text != "")
            {
                btnConfirm.Text = "Изменить";
            }
            
            
        }

        private void tbFerrMin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbFerrMax_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbSeIronMin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbSeIronMax_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbHGBMin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbHGBMax_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
