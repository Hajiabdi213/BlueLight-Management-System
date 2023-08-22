using System;

namespace BlueLight_Management_System.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public decimal Baaqi { get; set; }  

        public virtual Invoice Invoice { get; set; }
    }
}
