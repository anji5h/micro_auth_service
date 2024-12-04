namespace AuthService.Model
{
    public class UserModel : AuditModel
    {
        public UserModel()
        {
            UserId = Guid.NewGuid();
        }

        public Guid UserId { get; }

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;
    }
}