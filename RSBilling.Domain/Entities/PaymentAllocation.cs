using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSBilling.Domain.Entities
{
    public class PaymentAllocation
    {
        public int AllocationId { get; set; }
        public int PaymentId { get; set; } 
        public int DocumentId { get; set; }
        public decimal AllocatedAmount { get; set; }

        // Navigation Properties
        public virtual Payment Payment { get; set; } = null!;
        public virtual Document Document { get; set; } = null!;
    }

}
