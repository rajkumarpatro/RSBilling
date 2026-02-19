using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSBilling.Domain.Entities
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; } = string.Empty;
        public string? Category { get; set; }
        public bool IsGSTApplicable { get; set; } = true;
        public decimal DefaultGSTPercent { get; set; } = 18;
        public bool IsRecurring { get; set; } = false;

        // Navigation Properties
        public virtual ICollection<ClientServiceContract> ClientServiceContracts { get; set; }
        public virtual ICollection<DocumentItem> DocumentItems { get; set; }
    }
}
