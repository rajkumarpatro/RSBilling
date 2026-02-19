using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSBilling.Domain.Entities
{
    public class DocumentDispatch
    {
        public int DispatchId { get; set; }
        public int DocumentId { get; set; }
        public DispatchMode DispatchMode { get; set; }
        public DateTime DispatchDate { get; set; } = DateTime.Now;
        public string? ReferenceDetails { get; set; }
        public string? Remarks { get; set; }

        // Navigation Property
        public virtual Document Document { get; set; } = null!;
    }
}
