namespace RSBilling.Domain.Entities
{
    public class AuditLog
    {
        public int AuditId { get; set; }
        public string? EntityName { get; set; }
        public int? EntityId { get; set; }
        public string? Action { get; set; }
        public string? ChangedBy { get; set; }
        public DateTime ChangedOn { get; set; } = DateTime.Now;
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
    }
}
