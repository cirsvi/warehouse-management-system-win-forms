using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Models
{
    internal class SupplierForProduct
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public decimal PricePerUnit { get; set; }

        public SupplierForProduct (int supplierId, string supplierName, decimal pricePerUnit) 
        {
            this.SupplierId = supplierId;
            this.SupplierName = supplierName;
            this.PricePerUnit = pricePerUnit;
        }
    }
}
