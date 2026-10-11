using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Models
{
    internal class ProductForSupplier
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal PricePerUnit { get; set; }

        public ProductForSupplier(int productId, string productName, decimal pricePerUnit) 
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.PricePerUnit = pricePerUnit;
        }
    }
}
