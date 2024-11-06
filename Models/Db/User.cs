using Microsoft.AspNetCore.Identity;
using System;

namespace SocialNetwork.Models.Db
{
    public class User : IdentityUser
    {
        public override string UserName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public DateTime BirthDate { get; set; }

    }
}
