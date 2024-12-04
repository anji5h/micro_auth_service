using Microsoft.EntityFrameworkCore;

namespace AuthService.Context
{
    class AuthContext : DbContext
    {
        public AuthContext(DbContextOptions<AuthContext> options) : base(options)
        {

        }

        
    }
}