using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lap6._1_HuynhLeAnhVu
{
    public partial class PhoneForm : Form
    {
        List<Phone> phones = new List<Phone>();

        public PhoneForm()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listPhone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PhoneForm_Load(object sender, EventArgs e)
        {
            string[] l = File.ReadAllLines("D:\\ListPhone.txt");

            for (int i = 0; i < l.Length; i += 4)
            {
                Phone phone = new Phone();
                phone.ID = l[i];
                phone.brand = l[i + 1];
                phone.giaNhap = int.Parse(l[i + 2]);
                phone.pic = l[i + 3];
                phones.Add(phone);
            }

            foreach (Phone phone in phones)
            {
                ListViewItem item = new ListViewItem(phone.ID);
                item.SubItems.Add(phone.brand);
                item.SubItems.Add(phone.giaNhap.ToString());
                item.SubItems.Add(phone.pic);
                listPhone.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            //string[] l = File.ReadAllLines("D:\\ListPhone.txt");

            //for (int i = 0; i < l.Length; i += 4)
            //{
            //    Phone phone = new Phone();
            //    phone.ID = l[i];
            //    phone.branch = l[i + 1];
            //    phone.giaNhap = int.Parse(l[i + 2]);
            //    phone.pic = l[i + 3];
            //    phones.Add(phone);
            //}

            //phones.RemoveAll(phone => phone.ID == "06");

            //using (StreamWriter sw = new StreamWriter("D:\\ListPhone.txt"))
            //{
            //    foreach (Phone p in phones)
            //   {
            //     sw.WriteLine(p.ID);
            //     sw.WriteLine(p.branch);
            //     sw.WriteLine(p.giaNhap);
            //     sw.WriteLine(p.pic);
            //    }
            //}
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

            private void btnSort_Click( object sender, EventArgs e)
            {
                phones.Sort();
                listPhone.Items.Clear();
                foreach (Phone phone in phones)
                {
                    ListViewItem item = new ListViewItem(phone.ID);
                    item.SubItems.Add(phone.brand);
                    item.SubItems.Add(phone.giaNhap.ToString());
                    item.SubItems.Add(phone.pic);
                    listPhone.Items.Add(item);
                }
            }

        private void btnCalPrice_Click(object sender, EventArgs e)
        {
            foreach(Phone p in phones)
            {
                if(txtID.Text == p.ID)
                {
                    txtSellPrice.Text = p.calculatePrice().ToString();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG"; 
            if(open.ShowDialog() == DialogResult.OK) { 
                string filePate = open.FileName;

                picPhone.Image = Image.FromFile(filePate);
            }
        }
    }
}
