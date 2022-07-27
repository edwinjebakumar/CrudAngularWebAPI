using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWebAPI.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int InvNumber { get; set; } 
        public int CustNumber { get; set; }
        public DateTime InvDt { get; set; }
        public decimal Amount { get; set; }
        public bool VoidFlag { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }
    }
}