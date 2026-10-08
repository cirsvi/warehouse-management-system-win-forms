using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Models
{
    internal class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public Role(int roleId, string roleName)
        {
            this.RoleId = roleId;
            this.RoleName = roleName;
        }
    }
}
