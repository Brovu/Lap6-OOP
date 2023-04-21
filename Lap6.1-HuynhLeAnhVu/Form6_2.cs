using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap6._1_HuynhLeAnhVu
{
    public partial class Form6_2 : Form
    {
        public Form6_2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (radPtb1.Checked)
            {
                double a; 
                double b;
                double res;

                
                if(double.TryParse(txtA.Text, out a) && double.TryParse(txtB.Text, out b))
                {
                    PTB1 ptb1 = new PTB1(a, b);

                    res = ptb1.GiaiPT();
                    txtRes.Text = "x" + " = " + res + "";
                } else
                {
                   DialogResult box = MessageBox.Show(
                   "Bạn có muốn nhập lại không?",
                   "Lỗi định dạng",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Information
                   );
                    if (box == DialogResult.Cancel)
                    {
                        Close();
                    }
                }
            }
            if(radPtb2.Checked)
            {
                double a;
                double b;
                double c;
                

                if(double.TryParse(txtA.Text, out a) && double.TryParse(txtB.Text, out b) && double.TryParse(txtC.Text, out c))
                {
                    PTB2 ptb2 = new PTB2(a, b, c);

                    Tuple<double, double> result = ptb2.GiaiPT();

                    txtRes.Text = $"x1 = {result.Item1}, x2 = {result.Item2}";
                } else
                {
                    DialogResult box = MessageBox.Show(
                   "Bạn có muốn nhập lại không?",
                   "Lỗi định dạng",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Information
                   );
                    if (box == DialogResult.Cancel)
                    {
                        Close();
                    }
                }
            }
            }
        }
    }

