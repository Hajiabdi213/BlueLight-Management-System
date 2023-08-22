using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueLight_Management_System.Models
{
    public class InvoiceItem
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int ServiceId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        private decimal total;

        public decimal Total
        {
            get { return total; }
            set
            {
                total = Quantity*Price;
            }
        }


        public virtual Invoice Invoice { get; set; }
        public virtual Service Service { get; set; }
    }
}
