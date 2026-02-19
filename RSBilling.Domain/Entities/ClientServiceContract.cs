using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSBilling.Domain.Entities
{
    public class ClientServiceContract
    { 
        public int ContractId { get; set; }
        public int ClientId { get; set; }
        public int? ProjectId { get; set; }
        public int ServiceId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public BillingFrequency BillingFrequency { get; set; }
        public int RenewalReminderDays { get; set; } = 30;
        public DateTime? LastBilledDate { get; set; }
        public DateTime NextBillingDate { get; set; }
        public decimal Amount { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public virtual Client Client { get; set; } = null!;
        public virtual ClientProject? ClientProject { get; set; }
        public virtual Service Service { get; set; } = null!;
    }
}
