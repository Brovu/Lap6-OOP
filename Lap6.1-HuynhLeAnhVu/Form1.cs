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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            double a, b;

            if (double.TryParse(txtA.Text, out a) && double.TryParse(txtB.Text, out b))
            {
                double tru = a - b;
                txtRes.Text = tru.ToString();
            }
            else
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();     
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            double a, b;

            if (double.TryParse(txtA.Text, out a) && double.TryParse(txtB.Text, out b))
            {
                double tong = a + b;
                txtRes.Text = tong.ToString();
            }
            else
            {
                DialogResult box  = MessageBox.Show(
                    "Bạn có muốn nhập lại không?",
                    "Lỗi định dạng",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information
                    );
                if(box == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double a, b;

            if (double.TryParse(txtA.Text, out a) && double.TryParse(txtB.Text, out b))
            {
                double nhan = a * b;
                txtRes.Text = nhan.ToString();
            }
            else
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

        private void btnChia_Click(object sender, EventArgs e)
        {
            double a, b;

            if (double.TryParse(txtA.Text, out a) && double.TryParse(txtB.Text, out b))
            {
                double chia = a / b;
                txtRes.Text = chia.ToString();
            }
            else
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtRes.Text = "";

        }
    }
}
