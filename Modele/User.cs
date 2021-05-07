using System;
using Microsoft.AspNetCore.Identity;

namespace tetaix_circuit.Modele
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
