namespace AuthService.Model
{
    public class AuditModel
    {
        public AuditModel()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            IsDeleted = false;
        }

        public DateTime CreatedAt { get; }

        public DateTime UpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
    }
}