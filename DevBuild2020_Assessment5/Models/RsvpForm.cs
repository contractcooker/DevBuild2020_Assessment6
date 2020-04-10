using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevBuild2020_Assessment5.Models
{
    public class RsvpForm
    {
        private int id;
        private string firstName;
        private string lastName;
        private string emailAddress;
        private string attending;
        private string guest;
        private string attendanceDate;

        [DisplayName("First Name")]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string FirstName { get => firstName; set => firstName = value; }

        [DisplayName("Last Name")]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string LastName { get => lastName; set => lastName = value; }

        [DisplayName("E-mail")]
        [EmailAddress]
        [Required]
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }

        [Required]
        public string Attending { get => attending; set => attending = value; }

        
        public string Guest { get => guest; set => guest = value; }

        public string AttendanceDate { get => attendanceDate; set => attendanceDate = value; }
        public int Id { get => id; set => id = value; }
    }
}
