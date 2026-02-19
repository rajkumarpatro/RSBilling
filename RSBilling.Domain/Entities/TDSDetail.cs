using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSBilling.Domain.Entities
{
    public class TDSDetail
    {
        public int TDSId { get; set; }
        public int DocumentId { get; set; }
        public decimal? TDSPercent { get; set; } 
        public decimal? TDSAmount { get; set; }
        public string? CertificateNo { get; set; }
        public bool CertificateReceived { get; set; } = false;

        // Navigation Property
        public virtual Document Document { get; set; } = null!;
    }

}
