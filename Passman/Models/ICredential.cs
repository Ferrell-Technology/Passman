using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passman.Models
{
    internal interface ICredential
    {
        CredentialType Type { get; }
        public int Id { get; set; }
        public string Website { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        public string Notes { get; set; }
        string ToString();
    }
}
