using System;
    using Microsoft.AspNetCore.Identity;

namespace MANAOG_ITELEC_3ITE.Database
{
    public class User : IdentityUser
    {
        public string ? FirstName { get; set; }
        public string ? LastName { get; set; }

    }
}
