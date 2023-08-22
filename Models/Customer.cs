using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueLight_Management_System.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } 
        private string fullName;


        public string FullName
        {
            get { return fullName; }
            set { fullName = $"{FirstName} {LastName}"; }
        }
        public string Phone { get; set; } = "";
        public DateTime RegisteredAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }
}
