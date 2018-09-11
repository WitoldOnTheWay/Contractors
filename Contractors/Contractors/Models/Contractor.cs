using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contractors.Models
{
    public class Contractor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int PostalCode { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int NIP { get; set; }
        public string AccountNumber { get; set; }

    }
}