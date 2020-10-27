using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public string Bio { get; set; }
        public int MyProperty { get; set; }

        public ICollection<UserActivity> UserActivities { get; set; }

    }
}