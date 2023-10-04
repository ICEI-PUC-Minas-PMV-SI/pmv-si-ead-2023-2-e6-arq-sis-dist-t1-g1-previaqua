using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Infra.Configurations
{
    public class ApplicationUser : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public ApplicationUser()
        { 
        
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
