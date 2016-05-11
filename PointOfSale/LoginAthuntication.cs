using PointOfSale.DbConfiguration;
using PointOfSale.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class LoginAthuntication : Form
    {
        public LoginAthuntication()
        {
            InitializeComponent();
        }

        private void LoginAthuntication_Load(object sender, EventArgs e)
        {
           
            ArrayList users = new DatabaseCommands().readUsers();
            foreach (String user in users)
            {
                loginAthuntication_comboBox.Items.Add(user);
                Debug.WriteLine(user);
            }
        }

        private void LoginAthunticatuon_Cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void LoginAthunticatuon_Login_btn_Click(object sender, EventArgs e)
        {

            if (loginAthuntication_comboBox.SelectedIndex == -1 ||
                loginAthuntication_password_textbox.Text == "" )
            {

                MessageBox.Show("Please Give User Name Password");

            }
           
            else { 
                String loginAthn_userName = loginAthuntication_comboBox.SelectedItem.ToString();
                String loginAthn_password = loginAthuntication_password_textbox.Text;
                bool loginAthn_userLoginCheck = new DatabaseCommands().Login(loginAthn_userName, loginAthn_password);
               
                if (loginAthn_userLoginCheck==true)
                {

                    this.Close();
                    Constants.checkLogin = true;
                    new WorkingForm().Show();
                }
                else
                {
                    MessageBox.Show("Sorry User Not Found");
                }
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
