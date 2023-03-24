using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

[assembly: OwinStartup(typeof(EFDatabaseFirst.Identity.ApplicationUser))]

namespace EFDatabaseFirst.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}
