using System;
using Microsoft.AspNetCore.Identity;

namespace openwheels.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string UserAvatar { get; set; }
    }
}