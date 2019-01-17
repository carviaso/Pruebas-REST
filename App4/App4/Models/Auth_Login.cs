using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.App.Models
{
    public class Auth_Login
    {
        ///[JsonProperty("Email")]
        public string Email { get; set; }
        ///[JsonProperty("Password")]
        public string Password { get; set; }
    }
}
