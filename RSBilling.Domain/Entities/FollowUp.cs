using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSBilling.Domain.Entities
{
    public class FollowUp
    {
        public int FollowUpId { get; set; }
        public int DocumentId { get; set; }
        public DateTime FollowUpDate { get; set; } = DateTime.Now;
        public string? ClientResponse { get; set; }
        public DateTime? NextFollowUpDate { get; set; }
        public FollowUpStatus Status { get; set; }
        public string? CreatedBy { get; set; }

        // Navigation Property
        public virtual Document Document { get; set; } = null!;
    }

}
