using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BlueLight_Management_System.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        private string fullName;
        

        public string FullName
        {
            get { return  fullName; }
            set { fullName = $"{FirstName} {LastName}"; }
        }

        public string Phone { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime RegisteredAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public byte[] Picture { get; set; } = new byte[0];
        

    }
}
