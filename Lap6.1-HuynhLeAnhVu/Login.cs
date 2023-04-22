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

namespace Lap6._1_HuynhLeAnhVu
{
    public partial class Login : Form
    {
        List<User> listUsers = new List<User>();

        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User users = listUsers.Find(u => u.user_name == txtName.Text);
            User pass = listUsers.Find(p => p.password == txtPass.Text);
            if(users != null && pass != null)
            {
                MessageBox.Show("Logged in successfully!");
                this.Close();
            }

            if (users == null)
            {
                DialogResult box = MessageBox.Show(
                   "Invalid username!",
                   "Notification",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Information
                   );
                if (box == DialogResult.OK)
                {
                    txtName.Text = "";
                    txtName.Focus();
                }
                if(box == DialogResult.Cancel)
                {
                    Close();
                }
            }

            if(pass == null)
            {
                DialogResult box = MessageBox.Show(
                   "Invalid password!",
                   "Notification",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Information
                   );
                if (box == DialogResult.OK)
                {
                    txtPass.Text = "";
                    txtPass.Focus();
                }
                if (box == DialogResult.Cancel)
                {
                    Close();
                }
            }

           

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            StreamReader rd = new StreamReader("D:\\Users.txt");

            String l;
            while ((l = rd.ReadLine()) != null)
            {
                string[] value = l.Split(',');
                User users = new User(value[0], value[1]);
                listUsers.Add(users);
;            }
            rd.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
