using System;
using Microsoft.AspNetCore.Identity;

namespace yapf1.Models
{
    public class AppUser : IdentityUser
    {
         
        public string Name { get; set; }

        public string UserAvatar { get; set; }

    }
}