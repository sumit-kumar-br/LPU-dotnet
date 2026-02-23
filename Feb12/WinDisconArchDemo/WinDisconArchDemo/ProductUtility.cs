using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WinDisconArchDemo
{
    public interface IRepo<T> // Generic interface
    {
        bool AddData(T obj);
        bool UpdateData(int id,T obj);
        bool DeleteDate(int id);
        List<T> ShowAll();
        T SearchById(int id);
    }

    public interface IProductRepo : IRepo<Product> // specific interface
    {
        List<Product> ShowAllProductByCategory(int catID);
        List<Product> SortProductByPriceAsc();
        List<Product> SortProductByPriceDesc();
        List<Product> GetTop3CostlyProduct();
        List<Product> GetTop3BudgetProduct();

    }
    public class ProductUtility : IProductRepo
    {
        IDbConnection con;
        SqlDataAdapter adap1;
        DataSet ds;

        public ProductUtility()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=.\\sqlexpress;Integrated Security=True;Database=LPU_DB;TrustServerCertificate=true";
        }
        public bool AddData(Product obj)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDate(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetTop3BudgetProduct()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetTop3CostlyProduct()
        {
            throw new NotImplementedException();
        }

        public Product SearchById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> ShowAll()
        {
            List<Product> products = null;
            adap1 = new SqlDataAdapter("Select * from Products",(SqlConnection)con);
            adap1.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            ds = new DataSet();
            adap1.Fill(ds, "Products");
            if (ds.Tables[0].Rows.Count > 0)
            {
                products = new List<Product>();
                foreach(DataRow dRow in ds.Tables["Products"].Rows)
                {
                    Product p1 = new Product()
                    {
                        ProdID = Int32.Parse(dRow[0].ToString()),
                        ProdName = dRow[1].ToString(),
                        Category = dRow[2].ToString(),
                        Price = Single.Parse(dRow[3].ToString()),
                        Description = dRow[4].ToString(),

                    };
                    products.Add(p1);
                }
            }
            return products;
        }

        public List<Product> ShowAllProductByCategory(int catID)
        {
            throw new NotImplementedException();
        }

        public List<Product> SortProductByPriceAsc()
        {
            throw new NotImplementedException();
        }

        public List<Product> SortProductByPriceDesc()
        {
            throw new NotImplementedException();
        }

        public bool UpdateData(int id, Product obj)
        {
            throw new NotImplementedException();
        }
    }

}
