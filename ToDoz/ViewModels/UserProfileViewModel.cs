using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ToDoz.Models;

namespace ToDoz.ViewModels
{
    public class UserProfileViewModel : IdentityUser
    {
        

        public string Country { get; set; }

        public string EmailAddress { get; set; }

        public string Name { get; set; }

        public string ProfileImage { get; set; }

        public string Phone { get; set; }

        public string Adresse { get; set; }

        public string Birthday { get; set; }

        public string TasksDone { get; set; }

        public string Role { get; set; }

        public string Pool { get; set; }

        public string Lane { get; set; }



    }
}
