using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace BusinessPhone.Models
{
    public class Role:IdentityRole<int>
    {
        public ICollection<UserRole> UserRoles{set;get;}
    }
}