using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBuild2020_Assessment5.Models
{
    public class RsvpForm
    {
        private string firstName;
        private string lastName;
        private string email;
        private bool attending;
        private string guest;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public bool Attending { get => attending; set => attending = value; }
        public string Guest { get => guest; set => guest = value; }
    }
}
