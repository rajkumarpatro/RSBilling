using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSBilling.Domain.Entities
{
    public class DocumentItem
    {
        public int ItemId { get; set; }
        public int DocumentId { get; set; }
        public int? ServiceId { get; set; }
        public string? Description { get; set; }
        public decimal Quantity { get; set; } = 1;
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public decimal GSTPercent { get; set; } = 18;

        // Navigation Properties
        public virtual Document Document { get; set; } = null!;
        public virtual Service? Service { get; set; }
    }
}
