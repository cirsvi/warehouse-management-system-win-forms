using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Models
{
    internal class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Supplier() { }

        public Supplier(string supName, string contactPerson, 
            string phone, string email)
        {
            this.SupplierName = supName;
            this.ContactPerson = contactPerson;
            this.Phone = phone;
            this.Email = email;
        }

        public Supplier(int id, string supName, 
                        string contactPerson, string phone, string email)
        {
            this.SupplierId = id;
            this.SupplierName = supName;
            this.ContactPerson = contactPerson;
            this.Phone = phone;
            this.Email = email;
        }
    }
}
