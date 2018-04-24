using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTITY;
namespace DAL
{
    public class Account_DAL
    {
        string connString = "Data Source=(localdb)\\ProjectsV12;Initial Catalog=SuperShopDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Member getAdminOrMember(string name)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("GetAdminOrMember", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = name;
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                Member member = new Member();
                member.slNo = (string)reader["SL No"];
                member.name = (string)reader["Name"];
                member.password = (string)reader["Password"];
                member.type = (string)reader["Type"];

                reader.Close();
                return member;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool setProduct(Product product, string procedure)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand(procedure, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SLNo", SqlDbType.NVarChar, 50).Value = product.slNo;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = product.name;
                cmd.Parameters.Add("@Units", SqlDbType.NVarChar, 50).Value = product.units;
                cmd.Parameters.Add("@UnitsPrice", SqlDbType.NVarChar, 50).Value = product.unitPrice;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool setSellLists(Product product)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("SetSellsList", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SLNo", SqlDbType.NVarChar, 50).Value = product.slNo;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = product.name;
                cmd.Parameters.Add("@Units", SqlDbType.NVarChar, 50).Value = product.units;
                cmd.Parameters.Add("@UnitsPrice", SqlDbType.NVarChar, 50).Value = product.unitPrice;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataSet getProduct()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("Select * From Product", conn);
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sdp = new SqlDataAdapter();
                sdp.SelectCommand = cmd;
                sdp.Fill(ds);
                conn.Close();
                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataSet getSellLists()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("Select * From SellList", conn);
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sdp = new SqlDataAdapter();
                sdp.SelectCommand = cmd;
                sdp.Fill(ds);
                conn.Close();
                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataSet getTempProduct()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("Select * From TempProduct", conn);
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sdp = new SqlDataAdapter();
                sdp.SelectCommand = cmd;
                sdp.Fill(ds);
                conn.Close();
                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Product getSpecificProduct(string name)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("GetSpecificProduct", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = name;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                Product product = new Product();
                product.slNo = (string)reader["SL No"];
                product.name = (string)reader["Name"];
                product.units = (string)reader["Units"];
                product.unitPrice = (string)reader["Unit Price"];

                reader.Close();
                return product;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool updateProduct(Product product)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("UpdateProduct", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SLNo", SqlDbType.NVarChar, 50).Value = product.slNo;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = product.name;
                cmd.Parameters.Add("@Units", SqlDbType.NVarChar, 50).Value = product.units;
                cmd.Parameters.Add("@UnitsPrice", SqlDbType.NVarChar, 50).Value = product.unitPrice;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updateTempProduct(Product product)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("UpdateTempProduct", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SLNo", SqlDbType.NVarChar, 50).Value = product.slNo;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = product.name;
                cmd.Parameters.Add("@Units", SqlDbType.NVarChar, 50).Value = product.units;
                cmd.Parameters.Add("@UnitsPrice", SqlDbType.NVarChar, 50).Value = product.unitPrice;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deleteTempProduct()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("Delete dbo.TempProduct", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deleteSellLists()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("Delete dbo.SellList", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool setMember(Member member)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("SetMember", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SLNo", SqlDbType.NVarChar, 50).Value = member.slNo;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = member.name;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = member.password;
                cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = member.type;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataSet getMember()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("Select * From Members", conn);
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sdp = new SqlDataAdapter();
                sdp.SelectCommand = cmd;
                sdp.Fill(ds);
                conn.Close();
                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool updateMember(Member member)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("UpdateMember", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SLNo", SqlDbType.NVarChar, 50).Value = member.slNo;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = member.name;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = member.password;
                cmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50).Value = member.type;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool deleteMember(Member member)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("DeleteMember", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SLNo", SqlDbType.NVarChar, 50).Value = member.slNo;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = member.name;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
