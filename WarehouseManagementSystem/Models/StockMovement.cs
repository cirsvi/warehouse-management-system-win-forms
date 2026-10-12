using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Models
{
    internal class StockMovement
    {
        public int MovementId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public MovementType Type { get; set; }
        public int Quantity { get; set; }
        public DateTime MovementDate { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }

        public StockMovement(int prodId, int quantity, MovementType movType, 
                             DateTime date, string note)
        {
            this.ProductId = prodId;
            this.Type = movType;
            this.Quantity = quantity;
            this.MovementDate = date;
            this.Note = note;
        }

        public StockMovement(int prodId, int supId, int quantity, 
                             MovementType movType, DateTime date, string note)
        {
            this.ProductId = prodId;
            this.SupplierId = supId;
            this.Type = movType;
            this.Quantity = quantity;
            this.MovementDate = date;
            this.Note = note;
        }

        public StockMovement(int movId, int prodId, string prodName, int? supId, 
                             string supName, int quantity, MovementType movType,
                             DateTime date, string note, bool isActive)
        {
            this.MovementId = movId;
            this.ProductId = prodId;
            this.ProductName = prodName;
            this.SupplierId = supId;
            this.SupplierName = supName;
            this.Type = movType;
            this.Quantity = quantity;
            this.MovementDate = date;
            this.Note = note;
            this.IsActive = isActive;
        }
    }
}
