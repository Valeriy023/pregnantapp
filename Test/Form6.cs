using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            lbWarning.Visible = false;
            lbFerrConclusion1.Visible = false;
            lbFerrConclusion2.Visible = false;
            lbSeIronConclusion1.Visible = false;
            lbSeIronConclusion2.Visible=false;
            lbHgbConclusion1.Visible=false;
            lbHgbConclusion2.Visible=false;

            DataSet examDs = Globals.Repos.readDataWithExamId(Globals.examId,Globals.examId, "LabAnalysis");
            (string[], string[], string[]) Values = Globals.Repos.checkSettings();

            string Ferr = examDs.Tables[0].Rows[0].ItemArray[2].ToString();
            string SeIron = examDs.Tables[0].Rows[0].ItemArray[3].ToString();
            string HGB = examDs.Tables[0].Rows[0].ItemArray[4].ToString();

            lbFerrValue.Text = $"{Ferr} мкг/л";
            lbSeIronValue.Text = $"{SeIron} мкмоль/л";
            lbHgbValue.Text = $"{HGB} г/л";

            if (!Values.Item1.Contains("") && !Values.Item2.Contains("") && !Values.Item3.Contains(""))
            {
                if ((double.Parse(Ferr) < double.Parse(Values.Item1[0]) || (double.Parse(Ferr) > double.Parse(Values.Item1[1]))))
                {lbFerrConclusion2.Visible = true;}
                else {lbFerrConclusion1.Visible = true; }

                if ((double.Parse(SeIron) < double.Parse(Values.Item2[0]) || (double.Parse(SeIron) > double.Parse(Values.Item2[1]))))
                { lbSeIronConclusion2.Visible = true; }
                else { lbSeIronConclusion1.Visible = true; }

                if ((double.Parse(HGB) < double.Parse(Values.Item3[0]) || (double.Parse(HGB) > double.Parse(Values.Item3[1]))))
                { lbHgbConclusion2.Visible = true; }
                else { lbHgbConclusion1.Visible = true; }
            }
            else
            {
                lbWarning.Visible=true;
            }


        }
    }
}
