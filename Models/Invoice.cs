using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueLight_Management_System.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int InvoiceNumber { get; set; } 
        public int CustomerId { get; set; }
        public decimal SubTotal { get; set; }
        private decimal discount;

        public decimal Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private decimal paidAmount;

        public decimal PaidAmount
        {
            get { return paidAmount; }
            set { paidAmount = value; }
        }

        private decimal grandTotal;

        public decimal GrandTotal
        {
            get { return grandTotal; }
            set 
            {
                grandTotal = SubTotal-Discount; 
            }
        }



        private decimal baaqi;

        public decimal Baaqi
        {
            get { return baaqi; }
            set 
            {
                baaqi = GrandTotal - PaidAmount;
            }
        }

        public DateTime IssuedDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime PaidDate { get; set; }
        public string Status { get; set; } = string.Empty;

        public virtual Customer Customer { get; set; }
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
        public virtual ICollection<Payment> Payments{ get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Amount { get; internal set; }
    }
}
