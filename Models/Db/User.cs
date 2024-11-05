using Microsoft.AspNetCore.Identity;
using System;

namespace SocialNetwork.Models.Db
{
    public class User : IdentityUser
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime JoinDate { get; set; }

    }
}
