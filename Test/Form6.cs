using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
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
            lbConRec.Visible = false;
            lbB12Conclusion1.Visible = false;
            lbB12Conclusion2.Visible = false;
            lbB9Conclusion1.Visible = false;
            lbB9Conclusion2.Visible=false;
            lbHgbConclusion1.Visible=false;
            lbHgbConclusion2.Visible=false;
            tbConRec.Text = "";

            DataSet examDs = Globals.Repos.readDataWithExamId(Globals.examId,Globals.examId, "LabAnalysis");
            (string[], string[], string[]) Values = Globals.Repos.checkSettings();

            string B12 = examDs.Tables[0].Rows[0].ItemArray[2].ToString();
            string B9 = examDs.Tables[0].Rows[0].ItemArray[3].ToString();
            string HGB = examDs.Tables[0].Rows[0].ItemArray[4].ToString();

            lbB12Value.Text = $"{B12} пг/мл";
            lbB9Value.Text = $"{B9} нмоль/л";
            lbHgbValue.Text = $"{HGB} г/л";

            double b12_val = 0;
            double b9_val = 0;
            double hgb_val = 0;
            double b12_min = 160;
            double b12_max = 950;
            double b9_min = 7;
            double b9_max = 40;
            double hgb_min = 110;
            double hgb_max = 160;

            if (!Values.Item1.Contains("") && !Values.Item2.Contains("") && !Values.Item3.Contains(""))
            {
                b12_val = double.Parse(B12, NumberStyles.Any, CultureInfo.InvariantCulture);
                b9_val = double.Parse(B9, NumberStyles.Any, CultureInfo.InvariantCulture);
                hgb_val = double.Parse(HGB, NumberStyles.Any, CultureInfo.InvariantCulture);
                b12_min = double.Parse(Values.Item1[0], NumberStyles.Any, CultureInfo.InvariantCulture);
                b12_max = double.Parse(Values.Item1[1], NumberStyles.Any, CultureInfo.InvariantCulture);
                b9_min = double.Parse(Values.Item2[0], NumberStyles.Any, CultureInfo.InvariantCulture);
                b9_max = double.Parse(Values.Item2[1], NumberStyles.Any, CultureInfo.InvariantCulture);
                hgb_min = double.Parse(Values.Item3[0], NumberStyles.Any, CultureInfo.InvariantCulture);
                hgb_max = double.Parse(Values.Item3[1], NumberStyles.Any, CultureInfo.InvariantCulture);
            }
            else
            {
                lbWarning.Visible = true;
            }

            if (!Values.Item1.Contains("") && !Values.Item2.Contains("") && !Values.Item3.Contains(""))
            {
                if (b12_val < b12_min || b12_val > b12_max)
                {lbB12Conclusion2.Visible = true;}
                else {lbB12Conclusion1.Visible = true; }

                if (b9_val < b9_min || b9_val > b9_max)
                { lbB9Conclusion2.Visible = true; }
                else { lbB9Conclusion1.Visible = true; }

                if (hgb_val < hgb_min || hgb_val > hgb_max)
                { lbHgbConclusion2.Visible = true; }
                else { lbHgbConclusion1.Visible = true; }

                if (((b12_val >= b12_min) | (b12_val <= b12_max)) & ((b9_val >= b9_min) | (b9_val <= b9_max)) & ((hgb_val >= hgb_min) | (hgb_val <= hgb_max)))
                {

                    tbConRec.Text = "Все результаты обследования находятся в пределах нормы, дополнительное обследование не требуется.";

                }
                if (((hgb_val < hgb_min) | (hgb_val > hgb_max)) & ((b12_val >= b12_min) | (b12_val <= b12_max)) & ((b9_val >= b9_min) | (b9_val <= b9_max)))
                {

                    tbConRec.Text = "Подозрение на легкую форму железодефицитной анемии. Необходимо проконсультироваться с врачом.";

                }
                if (((hgb_val < 90) | (hgb_val > hgb_max)) & ((b12_val >= b12_min) | (b12_val <= b12_max)) & ((b9_val >= b9_min) | (b9_val <= b9_max)))
                {

                    tbConRec.Text = "Подозрение на тяжелую форму железодефицитной анемии. Необходимо проконсультироваться с врачом и провести дополнительное обследование.";

                }
                if (((hgb_val >= hgb_min) | (hgb_val <= hgb_max)) & ((b12_val < b12_min) | (b12_val > b12_max)) & ((b9_val >= b9_min) | (b9_val <= b9_max)))
                {

                    tbConRec.Text = "Подозрение на B12-дефицитную форму анемии. Необходимо проконсультироваться с врачом и провести дополнительное обследование.";
                }
                if (((hgb_val >= hgb_min) | (hgb_val <= hgb_max)) & ((b12_val >= b12_min) | (b12_val <= b12_max)) & ((b9_val < b9_min) | (b9_val > b9_max)))
                {

                    tbConRec.Text = "Подозрение на фолиеводефицитную форму анемии. Необходимо проконсультироваться с врачом и провести дополнительное обследование.";

                }
                if (((hgb_val >= hgb_min) | (hgb_val <= hgb_max)) & ((b12_val < b12_min) | (b12_val > b12_max)) & ((b9_val < b9_min) | (b9_val > b9_max)))
                {

                    tbConRec.Text = "Требуется дополнительное обследование для уточнения формы анемии";

                }
                if (((hgb_val < hgb_min) | (hgb_val > hgb_max)) & ((b12_val < b12_min) | (b12_val > b12_max)) & ((b9_val < b9_min) | (b9_val > b9_max)))
                {

                    tbConRec.Text = "Отклонение по нескольким показателям, требуется повторное обследование для постановки правильного диагноза";

                }
            }
            else
            {
                lbWarning.Visible=true;
            }
        }
    }
}
