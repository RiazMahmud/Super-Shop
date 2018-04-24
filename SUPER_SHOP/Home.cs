using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using ENTITY;
namespace SUPER_SHOP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void homeCrossPanel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeCrossPanel_MouseHover(object sender, EventArgs e)
        {
            homeCrossPanel.BackColor = Color.Red;
        }

        private void homeCrossPanel_MouseLeave(object sender, EventArgs e)
        {
            homeCrossPanel.BackColor = Color.White;
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            try
            {
                Account_BO account_BO = new Account_BO();

                if (loginUserName_txt.Text == "" || loginPassword_txt.Text == "")
                {
                    MessageBox.Show("Wrong!!! Enter the information fully");
                }
                else
                {

                    Member member = account_BO.getAdminOrMember(loginUserName_txt.Text);

                    if (member.password == loginPassword_txt.Text)
                    {
                        if (member.type == "Admin")
                        {
                            Home_Admin ha = new Home_Admin();
                            ha.Show();
                            this.Hide();
                        }
                        else
                        {
                            Home_Member hm = new Home_Member();
                            hm.getMemberStatus("Member");
                            hm.Show();
                            this.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Incorect UserName or Password");
                        loginUserName_txt.Clear();
                        loginPassword_txt.Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Incorect UserName or Password");
            }
        }

        private void proceed_btn_Click(object sender, EventArgs e)
        {
            Home_Member hm = new Home_Member();
            hm.getMemberStatus("Other");
            hm.Show();
            this.Hide();
        }
    }
}
