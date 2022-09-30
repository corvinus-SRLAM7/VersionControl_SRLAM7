
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using UserMaintenance_SRLAM7.Entities;
using User = UserMaintenance_SRLAM7.Entities.User;

namespace UserMaintenance_SRLAM7
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();

            lblLastName.Text = Resource1.FullName; // label1
            
            btnAdd.Text = Resource1.Add; // button1

            button1.Text = Resource1.Mentes;

            // listbox1
            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = txtLastName.Text,
                
            };
            users.Add(u);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
            saveFileDialog1.


        }
    }
}