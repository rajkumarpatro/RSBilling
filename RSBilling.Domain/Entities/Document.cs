using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RSBilling.Domain.Entities
{
    public class Document  
    { 
        public int DocumentId { get; set; }
        public int ClientId { get; set; }
        public int? ProjectId { get; set; }
        public DocumentType DocumentType { get; set; }
        public string DocumentNumber { get; set; } = string.Empty;
        public string? FinancialYear { get; set; }
        public DateTime DocumentDate { get; set; }
        public bool IsGST { get; set; } = true;
        public decimal SubTotal { get; set; }
        public decimal CGST { get; set; }
        public decimal SGST { get; set; }
        public decimal IGST { get; set; }
        public decimal TotalAmount { get; set; }
        public DocumentStatus Status { get; set; } = DocumentStatus.Draft;
        public string? Remarks { get; set; }

        // Navigation Properties
        public virtual Client Client { get; set; } = null!;
        public virtual ClientProject? ClientProject { get; set; }
        public virtual ICollection<DocumentItem> DocumentItems { get; set; }
        public virtual ICollection<DocumentDispatch> DocumentDispatches { get; set; }
        public virtual ICollection<FollowUp> FollowUps { get; set; }
        public virtual ICollection<PaymentAllocation> PaymentAllocations { get; set; }
        public virtual TDSDetail? TDSDetail { get; set; }
    }
}
