
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueLight_Management_System.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public string ServiceName { get; set; } = string.Empty;
        //[Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public ICollection<InvoiceItem > InvoiceItems { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
