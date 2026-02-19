using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSBilling.Domain.Entities
{
    public class ClientContact
    {
        public int ContactId { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Designation { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public bool IsPrimary { get; set; } = false;

        // Navigation Property
        public virtual Client Client { get; set; } = null!;
    }
}
