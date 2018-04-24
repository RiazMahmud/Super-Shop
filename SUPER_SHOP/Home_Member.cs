using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BO;
namespace SUPER_SHOP
{
    public partial class Home_Member : Form
    {
        public Home_Member()
        {
            InitializeComponent();
        }
        Account_BO account_Bo = new Account_BO();
        string member;
        public void getMemberStatus(string m)
        {
            member = m;
        }
        private int SLNo = 0;
        private void reloadShoppingCartDataGridview()
        {
            DataSet ds = account_Bo.getTempProduct();
            shoppingCartDataGridView.DataSource = ds.Tables[0];
            shoppingCartDataGridView.ForeColor = Color.Black;
            shoppingCartDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SLNo = shoppingCartDataGridView.Rows.Count - 1;
        }

        private void reloadProductDataGridview()
        {
            DataSet ds = account_Bo.getProduct();
            ProductList_dataGridView.DataSource = ds.Tables[0];
            ProductList_dataGridView.ForeColor = Color.Black;
            ProductList_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void selectPanelAddProduct_btn_Click(object sender, EventArgs e)
        {
            if (selectPanelUnits_txt.Text != "")
            {
                int m = Convert.ToInt32(available_lable.Text);
                int dif = m - Convert.ToInt32(selectPanelUnits_txt.Text);
                if (dif >= 0 && m != 0)
                {
                    try
                    {

                        SLNo += 1;
                        Product product = new Product();
                        product.slNo = SLNo.ToString();
                        product.name = ProductList_dataGridView.CurrentRow.Cells[1].Value.ToString();
                        product.units = selectPanelUnits_txt.Text;
                        product.unitPrice = ProductList_dataGridView.CurrentRow.Cells[3].Value.ToString();
                        if (account_Bo.setProduct(product, "SetTempProduct"))
                        {
                            reloadShoppingCartDataGridview();
                            Product product1 = new Product();
                            product1.slNo = ProductList_dataGridView.CurrentRow.Cells[0].Value.ToString();
                            product1.name = ProductList_dataGridView.CurrentRow.Cells[1].Value.ToString();
                            product1.units = dif.ToString();
                            product1.unitPrice = ProductList_dataGridView.CurrentRow.Cells[3].Value.ToString();
                            account_Bo.updateProduct(product1);
                            reloadProductDataGridview();
                            productAvUnits_txt.Clear();
                            productName_txt.Clear();
                            productUnitPrice_txt.Clear();
                            available_lable.ResetText();
                            selectPanelUnits_txt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Already Purchased");
                            productAvUnits_txt.Clear();
                            productName_txt.Clear();
                            productUnitPrice_txt.Clear();
                            available_lable.ResetText();
                            selectPanelUnits_txt.Clear();
                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Already Purchased");
                    }
                }
                else
                {
                    MessageBox.Show("Sorry! You Can't Select More Than Available Units");
                    selectPanelUnits_txt.Clear();
                }
            }
            else
            {
                MessageBox.Show("Enter The Information Fully");
            }
        }

        private void shoppingCartUpadated_btn_Click(object sender, EventArgs e)
        {
            if (shoppingCartUpdatedUnits_txt.Text != "")
            {
                int updatedItem = Convert.ToInt32(shoppingCartUpdatedUnits_txt.Text) - Convert.ToInt32(shoopinCartTakenUnits_txt.Text);
                if (updatedItem >= 0)
                {
                    Product product = account_Bo.getSpecificProduct(shoppingCartName_txt.Text);
                    try
                    {
                       

                        int dif = Convert.ToInt32(product.units) - updatedItem;
                        if (dif >= 0)
                        {
                            try
                            {
                                
                                product.units = dif.ToString();
                               
                                if(account_Bo.updateProduct(product))
                                {
                                    MessageBox.Show("Product Cart Successfully Updated");
                                    reloadProductDataGridview();
                                    Product p2 = new Product();
                                    p2.slNo = shoppingCartDataGridView.CurrentRow.Cells[0].Value.ToString();
                                    p2.name = shoppingCartName_txt.Text;
                                    p2.units = shoppingCartUpdatedUnits_txt.Text;
                                    p2.unitPrice = shoppingCartDataGridView.CurrentRow.Cells[3].Value.ToString();
                                    account_Bo.updateTempProduct(p2);
                                    reloadShoppingCartDataGridview();
                                    shoppingCartUpdatedUnits_txt.Clear();
                                    shoppingCartName_txt.Clear();
                                    shoopinCartTakenUnits_txt.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Error");
                                }
                             
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sorry! You Can't Select More Than Available Units");
                            shoppingCartUpdatedUnits_txt.Clear();
                        }


                    }
                    catch
                    {

                    }
                }
                else
                {
                    Product product = account_Bo.getSpecificProduct(shoppingCartName_txt.Text);
                    try
                    {


                        int dif = Convert.ToInt32(product.units) - updatedItem;
                        if (dif >= 0)
                        {
                            try
                            {

                                product.units = dif.ToString();

                                if (account_Bo.updateProduct(product))
                                {
                                    MessageBox.Show("Product Cart Successfully Updated");
                                    reloadProductDataGridview();
                                    Product p2 = new Product();
                                    p2.slNo = shoppingCartDataGridView.CurrentRow.Cells[0].Value.ToString();
                                    p2.name = shoppingCartName_txt.Text;
                                    p2.units = shoppingCartUpdatedUnits_txt.Text;
                                    p2.unitPrice = shoppingCartDataGridView.CurrentRow.Cells[3].Value.ToString();
                                    account_Bo.updateTempProduct(p2);
                                    reloadShoppingCartDataGridview();
                                    shoppingCartUpdatedUnits_txt.Clear();
                                    shoppingCartName_txt.Clear();
                                    shoopinCartTakenUnits_txt.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Error");
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sorry! You Can't Select More Than Available Units");
                            shoppingCartUpdatedUnits_txt.Clear();
                        }


                    }
                    catch
                    {

                    }

                }

            }
            else
            {
                MessageBox.Show("Enter The Information Fully");
            }
            
            
        }

        private void getTotal_btn_Click(object sender, EventArgs e)
        {
            double total = 0.0;
            for (int i = 0; i < shoppingCartDataGridView.Rows.Count; i++)
            {
                total += Convert.ToInt32(shoppingCartDataGridView.Rows[i].Cells[3].Value) * Convert.ToInt32(shoppingCartDataGridView.Rows[i].Cells[2].Value);
            }
            if (member == "Member")
            {
                double m = total * 0.1;
                total_txt.Text = total.ToString();
                discount_txt.Text = "10%";
                total = total - m;
                netTotal_txt.Text = total.ToString();
            }
            else
            {
                total_txt.Text = total.ToString();
                discount_txt.Text = "0%";
                netTotal_txt.Text = total.ToString();
            }
        }

        private void checkOut_btn_Click(object sender, EventArgs e)
        {
             if (total_txt.Text != "")
            {
                Product product = new Product();
                try
                {
                    for (int i = 0; i < shoppingCartDataGridView.Rows.Count -1; i++)
                    {
                        product.slNo = shoppingCartDataGridView.Rows[i].Cells[0].Value.ToString();
                        product.name = shoppingCartDataGridView.Rows[i].Cells[1].Value.ToString();
                        product.units = shoppingCartDataGridView.Rows[i].Cells[2].Value.ToString();
                        product.unitPrice = shoppingCartDataGridView.Rows[i].Cells[3].Value.ToString();
                        Console.WriteLine(product.slNo);
                        Console.WriteLine(product.name);
                        Console.WriteLine(product.units);
                        Console.WriteLine(product.unitPrice);
                        account_Bo.setSellLists(product);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Thank You For Shopping");
                account_Bo.deleteTempProduct();
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Check GET TOTAL Button");
            }
        
        }

        private void Home_Member_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = account_Bo.getProduct();
                ProductList_dataGridView.DataSource = ds.Tables[0];
                ProductList_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductList_dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                productName_txt.Text = ProductList_dataGridView.CurrentRow.Cells[1].Value.ToString();
                productAvUnits_txt.Text = ProductList_dataGridView.CurrentRow.Cells[2].Value.ToString();
                productUnitPrice_txt.Text = ProductList_dataGridView.CurrentRow.Cells[3].Value.ToString();
                available_lable.Text = ProductList_dataGridView.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Isn't Exist");
            }
        }

        string productSlNo;
        string productUnitPrice;
        private void shoppingCartDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                productSlNo = shoppingCartDataGridView.CurrentRow.Cells[0].Value.ToString();
                productUnitPrice = shoppingCartDataGridView.CurrentRow.Cells[3].Value.ToString();
                shoppingCartName_txt.Text = shoppingCartDataGridView.CurrentRow.Cells[1].Value.ToString();
                shoopinCartTakenUnits_txt.Text = shoppingCartDataGridView.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Isn't Exist");
            }
        }

        private void home_pnl_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            account_Bo.deleteSellLists();
            h.Show();
            this.Hide();
        }

        private void home_pnl_MouseHover(object sender, EventArgs e)
        {
            home_pnl.BackColor = Color.Red;
        }

        private void home_pnl_MouseLeave(object sender, EventArgs e)
        {
            home_pnl.BackColor = Color.White;
        }
    }
}
