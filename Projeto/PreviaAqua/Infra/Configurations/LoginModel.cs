using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Configurations
{
    public class LoginModel
    {
        public LoginModel(string username, string password, string email)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}

