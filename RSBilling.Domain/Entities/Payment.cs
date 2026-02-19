using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSBilling.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public int PaymentId { get; set; }
        public int ClientId { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentMode PaymentMode { get; set; }
        public decimal ReceivedAmount { get; set; }
        public string? ReferenceNo { get; set; }
        public string? Remarks { get; set; }

        // Navigation Properties
        public virtual Client Client { get; set; } = null!;
        public virtual ICollection<PaymentAllocation> PaymentAllocations { get; set; }
    }

}
