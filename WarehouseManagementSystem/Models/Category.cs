using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Models
{
    internal class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int ProductCount { get; set; }

        public Category(string categoryName)
        {
            this.CategoryName = categoryName;
        }

        public Category() { }

        public Category(int categoryID, string categoryName)
        {
            this.CategoryID = categoryID;
            this.CategoryName = categoryName;
        }

        public Category(int categoryID, string categoryName, int productCount)
        {
            this.CategoryID = categoryID;
            this.CategoryName = categoryName;
            this.ProductCount = productCount;
        }
    }
}
