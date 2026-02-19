using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RSBilling.Domain.Entities
{
    public class Client  
    { 
        public int ClientId { get; set; }
        public string ClientCode { get; set; } = string.Empty;
        public string LongName { get; set; } = string.Empty;
        public string? ShortName { get; set; }
        public string? ClientType { get; set; }
        public string? GSTIN { get; set; }
        public string? PAN { get; set; }
        public string? StateCode { get; set; }
        public string? BillingDesignation { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? District { get; set; }
        public string? Pincode { get; set; }
        public string? Website { get; set; }
        public string? PrimaryEmail { get; set; }
        public int PaymentTermsDays { get; set; } = 30;
        public ClientStatus Status { get; set; } = ClientStatus.Active;

        // Navigation Properties
        public virtual ICollection<ClientContact> ClientContacts { get; set; }
        public virtual ICollection<ClientProject> ClientProjects { get; set; }
        public virtual ICollection<ClientServiceContract> ClientServiceContracts { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
