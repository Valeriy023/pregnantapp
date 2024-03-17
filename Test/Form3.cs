using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;

namespace Test
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Patient temp = Globals.Repos.getPatientWithId(Globals.id);
            if (temp != null) 
            { 
                tbName.Text = temp.FirstName;
                tbLastName.Text = temp.LastName;
                tbPhoneNumber.Text = temp.PhoneNumber;
                tbPatronymic.Text = temp.Patronymic;
                tbOms.Text = temp.OmsPolicyNumber;
                //dtp.Value = DateTime.ParseExact(temp.DateOfBirth,"d",null);
                dtp.Value = Convert.ToDateTime(temp.DateOfBirth,CultureInfo.CurrentCulture);
            }
        }
    }
}
