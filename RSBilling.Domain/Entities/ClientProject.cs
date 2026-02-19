using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RSBilling.Domain.Entities
{
    public class ClientProject
    {
        public int ProjectId { get; set; } 
        public int ClientId { get; set; }
        public string ProjectName { get; set; } = string.Empty;
        public string? ProjectType { get; set; }
        public string? DomainName { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public virtual Client Client { get; set; } = null!;
        public virtual ICollection<ClientServiceContract> ClientServiceContracts { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
    }
}
