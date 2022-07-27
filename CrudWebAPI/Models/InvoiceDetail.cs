using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWebAPI.Models
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        public int Item { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public decimal Tax { get; set; }
    }
}