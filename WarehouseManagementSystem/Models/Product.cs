using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Models
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCategoryId {  get; set; }
        public string ProductCategoryName { get; set; }
        public int CurrentStock { get; set; }

        public Product() { }

        public Product(int productId, string productName, 
                       int productCategoryId, string productCategoryName, int productStock)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.ProductCategoryId = productCategoryId;
            this.ProductCategoryName = productCategoryName;
            this.CurrentStock = productStock;
        }

        public Product(string productName, int productCategoryId)
        {
            this.ProductName = productName;
            this.ProductCategoryId = productCategoryId;
        }
    }
}
