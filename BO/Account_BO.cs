using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ENTITY;
using DAL;
namespace BO
{
    public class Account_BO
    {
        Account_DAL account_DAL = new Account_DAL();
        public Member getAdminOrMember(string name)
        {
            return account_DAL.getAdminOrMember(name);
        }

        public DataSet getSellLists()
        {
            return account_DAL.getSellLists();
        }
        public bool setProduct(Product product, string procedure)
        {
            return account_DAL.setProduct(product, procedure);
        }
        public bool setSellLists(Product product)
        {
            return account_DAL.setSellLists(product);
        }
        public DataSet getProduct()
        {
            return account_DAL.getProduct();
        }
        public DataSet getTempProduct()
        {
            return account_DAL.getTempProduct();
        }
        public Product getSpecificProduct(string name)
        {
            return account_DAL.getSpecificProduct(name);
        }

        public bool updateProduct(Product product)
        {
            return account_DAL.updateProduct(product);
        }
        public bool updateTempProduct(Product product)
        {
            return account_DAL.updateTempProduct(product);
        }
        public bool deleteTempProduct()
        {
            return account_DAL.deleteTempProduct();
        }
        public bool setMember(Member member)
        {
            return account_DAL.setMember(member);
        }

        public DataSet getMember()
        {
            return account_DAL.getMember();
        }

        public bool updateMember(Member member)
        {
            return account_DAL.updateMember(member);
        }

        public bool deleteMember(Member member)
        {
            return account_DAL.deleteMember(member);
        }
        public bool deleteSellLists()
        {
            return account_DAL.deleteSellLists();
        }  
    }
}
