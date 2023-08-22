using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueLight_Management_System.Models
{
    public class InvoiceItemDetails
    {
      
        public string serviceName { get; set; }
        public decimal price { get; set; }
        public int invoiceId { get; set; }
        public decimal subtotal { get; set; }
        public int quantity { get; set; }
        public decimal invoiceItemTotal { get; set; }
        public decimal paidAmount { get; set; }
        public decimal discount { get; set; }
        public decimal baaqi { get; set; }
        public decimal grandTotal { get; set; }
        public DateTime issuedDate { get; set; }
        public string paymentMethod { get; set; }
        public string customerName { get; set; }
        public string customerPhone { get; set; }
    }

}
