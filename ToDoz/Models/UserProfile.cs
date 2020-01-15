using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToDoz.ViewModels;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace ToDoz.Models
{
    public class AppUser : IdentityUser
    {
        public string Country { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public string ProfileImage { get; set; }
        public string Phone { get; set; }
        public string Adresse { get; set; }
        public string Birthday { get; set; }
        public string Pool { get; set; }
        public string Lane { get; set; }



    }
    
}
