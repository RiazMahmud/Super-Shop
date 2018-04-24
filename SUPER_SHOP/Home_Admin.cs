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
    public partial class Home_Admin : Form
    {
        public Home_Admin()
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
        Account_BO account_Bo = new Account_BO();
        private int SLNo = 0;
        private void reloadProductDataGridview()
        {
            try
            {
                DataSet ds = account_Bo.getProduct();
                ProductList_dataGridView.DataSource = ds.Tables[0];
                ProductList_dataGridView.ForeColor = Color.Black;
                ProductList_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                SLNo = ProductList_dataGridView.Rows.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reloadMemberDataGridview()
        {
            DataSet ds = account_Bo.getMember();
            memberLists_dataGridView.DataSource = ds.Tables[0];
            memberLists_dataGridView.ForeColor = Color.Black;
            memberLists_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SLNo = memberLists_dataGridView.Rows.Count - 1;
        }

        private void reloadSellListsDataGridview()
        {
            DataSet ds = account_Bo.getSellLists();
            soldItem_dataGridView.DataSource = ds.Tables[0];
            soldItem_dataGridView.ForeColor = Color.Black;
            soldItem_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void product_btn_Click(object sender, EventArgs e)
        {
            productList_grpBox.Visible = true;
            productList_grpBox.Location = new Point(237, 65);
            productList_grpBox.Size = new Size(806, 572);
            meberList_grpBox.Visible = false;
            sellLists_grpBox.Visible = false;
            product_btn.BackColor = Color.DarkCyan;
            sellsList_btn.BackColor = Color.White;
            members_btn.BackColor = Color.White;
            reloadProductDataGridview();
        }

        private void sellsList_btn_Click(object sender, EventArgs e)
        {
            sellLists_grpBox.Visible = true;
            sellLists_grpBox.Location = new Point(237, 65);
            sellLists_grpBox.Size = new Size(806, 572);
            productList_grpBox.Visible = false;
            meberList_grpBox.Visible = false;
            product_btn.BackColor = Color.White;
            sellsList_btn.BackColor = Color.DarkCyan;
            members_btn.BackColor = Color.White;
            reloadSellListsDataGridview();
        }

        private void members_btn_Click(object sender, EventArgs e)
        {
            meberList_grpBox.Visible = true;
            meberList_grpBox.Location = new Point(237, 65);
            meberList_grpBox.Size = new Size(806, 572);
            productList_grpBox.Visible = false;
            sellLists_grpBox.Visible = false;
            product_btn.BackColor = Color.White;
            sellsList_btn.BackColor = Color.White;
            members_btn.BackColor = Color.DarkCyan;
            reloadMemberDataGridview();
        }

        private void Home_Admin_Load(object sender, EventArgs e)
        {
            productList_grpBox.Visible = true;
            productList_grpBox.Location = new Point(237, 65);
            productList_grpBox.Size = new Size(806, 572);
            meberList_grpBox.Visible = false;
            sellLists_grpBox.Visible = false;
            product_btn.BackColor = Color.DarkCyan;
            sellsList_btn.BackColor = Color.White;
            members_btn.BackColor = Color.White;
            reloadProductDataGridview();
        }

        private void addProduct_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (productName_txt.Text != "" && productAvUnits_txt.Text != "" && productUnitPrice_txt.Text != "")
                {
                    SLNo += 1;
                    Product product = new Product();
                    product.slNo = SLNo.ToString();
                    product.name = productName_txt.Text;
                    product.units = productAvUnits_txt.Text;
                    product.unitPrice = productUnitPrice_txt.Text;
                    if (account_Bo.setProduct(product, "SetProduct"))
                    {
                        MessageBox.Show("Product Added Successfully Done");
                        reloadProductDataGridview();
                        productName_txt.Clear();
                        productAvUnits_txt.Clear();
                        productUnitPrice_txt.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Same Named Item Is Already Exists!!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter The Information Fully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productUpdate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (productName_txt.Text != "" && productAvUnits_txt.Text != "" && productUnitPrice_txt.Text != "")
                {
                    string SlNo = ProductList_dataGridView.CurrentRow.Cells[0].Value.ToString();
                    Product product = new Product();
                    product.slNo = SlNo;
                    product.name = productName_txt.Text;
                    product.units = productAvUnits_txt.Text;
                    product.unitPrice = productUnitPrice_txt.Text;
                    if (account_Bo.updateProduct(product))
                    {
                        MessageBox.Show("Product Update Successfully Done");
                        reloadProductDataGridview();

                        productName_txt.Clear();
                        productAvUnits_txt.Clear();
                        productUnitPrice_txt.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Same Named Item Is Already Exists!!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter The Information Fully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter The Information Fully");
            }
        }

        private void addmember_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (memberListName_txt.Text != "" && memberListPassword_txt.Text != null && memberListType_comboBox.Text != "")
                {
                    SLNo += 1;
                    Member member = new Member();
                    member.slNo = SLNo.ToString();
                    member.name = memberListName_txt.Text;
                    member.password = memberListPassword_txt.Text;
                    member.type = memberListType_comboBox.Text;
                    if (account_Bo.setMember(member))
                    {
                        MessageBox.Show("Member Added Successfully Done");
                        reloadMemberDataGridview();

                        memberListName_txt.Clear();
                        memberListPassword_txt.Clear();
                        memberListType_comboBox.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Same Named Member Is Already Exists!!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter The Information Fully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateMember_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (memberListName_txt.Text != "" && memberListPassword_txt.Text != null && memberListType_comboBox.Text != "")
                {
                    string SlNo = memberLists_dataGridView.CurrentRow.Cells[0].Value.ToString();
                    Member member = new Member();
                    member.slNo = SlNo;
                    member.name = memberListName_txt.Text;
                    member.password = memberListPassword_txt.Text;
                    member.type = memberListType_comboBox.Text;
                    if (account_Bo.updateMember(member))
                    {
                        MessageBox.Show("Member Updated Successfully Done");
                        reloadMemberDataGridview();

                        memberListName_txt.Clear();
                        memberListPassword_txt.Clear();
                        memberListType_comboBox.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Same Named Member Is Already Exists!!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter The Information Fully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteMember_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (memberListName_txt.Text != "" && memberListPassword_txt.Text != null && memberListType_comboBox.Text != "")
                {
                    string SlNo = memberLists_dataGridView.CurrentRow.Cells[0].Value.ToString();
                    Member member = new Member();
                    member.slNo = SlNo;
                    member.name = memberListName_txt.Text;
                    if (account_Bo.deleteMember(member))
                    {
                        MessageBox.Show("Member Deleted Successfully Done");
                        reloadMemberDataGridview();

                        memberListName_txt.Clear();
                        memberListPassword_txt.Clear();
                        memberListType_comboBox.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Error!!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter The Information Fully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearData_btn_Click(object sender, EventArgs e)
        {
            account_Bo.deleteSellLists();
            reloadSellListsDataGridview();
        }

        private void ProductList_dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                productName_txt.Text = ProductList_dataGridView.CurrentRow.Cells[1].Value.ToString();
                productAvUnits_txt.Text = ProductList_dataGridView.CurrentRow.Cells[2].Value.ToString();
                productUnitPrice_txt.Text = ProductList_dataGridView.CurrentRow.Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Isn't Exist");
            }
        }

        private void memberLists_dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                memberListName_txt.Text = memberLists_dataGridView.CurrentRow.Cells[1].Value.ToString();
                memberListPassword_txt.Text = memberLists_dataGridView.CurrentRow.Cells[2].Value.ToString();
                memberListType_comboBox.Text = memberLists_dataGridView.CurrentRow.Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Isn't Exist");
            }
        }

        private void home_pnl_MouseHover(object sender, EventArgs e)
        {
            home_pnl.BackColor = Color.Red;
        }

        private void home_pnl_MouseLeave(object sender, EventArgs e)
        {
            home_pnl.BackColor = Color.White;
        }

        private void home_pnl_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            account_Bo.deleteSellLists();
            h.Show();
            this.Hide();
        }
    }
}
