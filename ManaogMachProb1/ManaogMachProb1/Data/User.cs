using System;
using Microsoft.AspNetCore.Identity;

namespace ManaogMachProb1.Data
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set;}
        public string? LastName { get; set;}
    }
}
