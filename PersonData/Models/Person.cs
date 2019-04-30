using System;
using System.Collections.Generic;

namespace PersonData
{
    public class Person
    {
        public long PersonId { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string MiddleName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhotoFileName { get; set; }

        public virtual List<Interest> Interests { get; set; }
    }
}
