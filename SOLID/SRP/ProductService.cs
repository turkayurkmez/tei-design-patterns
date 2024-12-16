using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class ProductService
    {
        public int AddNewProduct(string name, decimal price)
        {
            
            var helper = new SQlHelper();   
            return helper.ExecuteNonQuery($"bişeyler bişeyler");
        }
    }
}
