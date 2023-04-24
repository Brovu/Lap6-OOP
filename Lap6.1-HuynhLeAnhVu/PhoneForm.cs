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
            

            FileStream f = new FileStream("D:\\ListPhone.txt", FileMode.Open, FileAccess.Read);
            StreamReader rd = new StreamReader(f);

            int n = int.Parse(rd.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string id = rd.ReadLine();
                string name = rd.ReadLine();
                int price = int.Parse(rd.ReadLine());
                string url = rd.ReadLine();

                Phone phone = new Phone(id, name, price, url);
                phones.Add(phone);
            }

            listPhone.Items.Clear();
            foreach (Phone phone in phones)
            {
                ListViewItem item = new ListViewItem(phone.ID);
                item.SubItems.Add(phone.branch);
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

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSort_Click( object sender, EventArgs e)
        {
            phones.Sort();
        }
    }
}
