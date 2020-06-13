using Microsoft.AspNetCore.Identity;

namespace BusinessPhone.Models
{
    public class UserRole:IdentityUserRole<int>
    {
        public User User{set;get;}
        public Role Role{set;get;}
    }
}