using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueLight_Management_System.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = "Company Name";
        public byte[] CompanyLogo { get; set; } = new byte[0];
    }
}
