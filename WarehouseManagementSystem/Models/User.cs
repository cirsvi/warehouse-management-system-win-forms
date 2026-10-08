using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Models
{
    internal class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string CreatedOn { get; set; }

        public User() { }

        public User(int userId, string userName, int roleId)
        {
            this.UserId = userId;
            this.Username = userName;
            this.RoleId = roleId;
        }
        public User(string userName, string password, int roleId)
        {
            this.Username = userName;
            this.PasswordHash = password;
            this.RoleId = roleId;
        }

        public User(int userId, string userName, int roleId, string roleName, string createdOn)
        {
            this.UserId = userId;
            this.Username = userName;
            this.RoleId = roleId;
            this.RoleName = roleName;
            this.CreatedOn = createdOn;
        }

        public User(int userId, string userName, string passwordHash, int roleId, string roleName)
        {
            this.UserId = userId;
            this.Username = userName;
            this.PasswordHash = passwordHash;
            this.RoleId = roleId;
            this.RoleName = roleName;
        }
    }
}
