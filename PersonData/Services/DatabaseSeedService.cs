using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonData
{
    public class DatabaseSeedService : IDatabaseSeedService
    {
        private readonly SearchContext context;

        public DatabaseSeedService(SearchContext context)
        {
            this.context = context;
        }

        public void Seed()
        {
            context.Database.EnsureCreated();

            // Don't reseed when people exist in the database
            if (context.People.Any())
                return;

            var peoples = new Person[]
            {
                new Person() { Address1 = "123 Seattle Way", Address2 = "Apt 456", State = "WA", Country = "USA", City = "Mount Vernon",
                    BirthDate = new DateTime(1967, 4, 2), GivenName = "Bill", FamilyName = "Tester", MiddleName = "J", PostalCode = "98765",
                    Interests = new List<Interest>() { new Interest() {Name = "Skiing" } } },
                new Person() { Address1 = "123 Olympia Way", Address2 = "Apt 456", State = "WA", Country = "USA", City = "Marysville",
                    BirthDate = new DateTime(1983, 3, 30), GivenName = "Bob", FamilyName = "Wester", MiddleName = "J", PostalCode = "98765",
                    Interests = new List<Interest>() { new Interest() {Name = "Snorkeling" } } },
                new Person() { Address1 = "123 Shelton Way", Address2 = "Apt 456", State = "WA", Country = "USA", City = "Burien",
                    BirthDate = new DateTime(1945, 6, 16), GivenName = "BryanTest", FamilyName = "Bester", MiddleName = "J", PostalCode = "98765",
                    Interests = new List<Interest>() { new Interest() {Name = "Swimming" } } },
                new Person() { Address1 = "123 Bellevue Way", Address2 = "Apt 456", State = "WA", Country = "USA", City = "Pasco",
                    BirthDate = new DateTime(1980, 11, 5), GivenName = "Blake", FamilyName = "Duster", MiddleName = "J", PostalCode = "98765",
                    Interests = new List<Interest>() { new Interest() {Name = "Skydiving" } } },
                new Person() { Address1 = "123 Spokane Way", Address2 = "Apt 456", State = "WA", Country = "USA", City = "Sammamish",
                    BirthDate = new DateTime(1967, 12, 12), GivenName = "Bethtest", FamilyName = "Muster", MiddleName = "J", PostalCode = "98765",
                    Interests = new List<Interest>() { new Interest() {Name = "Spelunking" } } },
                new Person() { Address1 = "123 Vancouver Way", Address2 = "Apt 456", State = "WA", Country = "USA", City = "Duvall",
                    BirthDate = new DateTime(1970, 9, 5), GivenName = "Boscoe", FamilyName = "Tester", MiddleName = "J", PostalCode = "98765",
                    Interests = new List<Interest>() { new Interest() {Name = "Reading" }, new Interest() { Name="Surfing" } } },
                new Person() { Address1 = "123 Republic Way", Address2 = "Apt 456", State = "WA", Country = "USA", City = "Redmond",
                    BirthDate = new DateTime(1974, 8, 15), GivenName = "Benjamin", FamilyName = "Nestor", MiddleName = "J", PostalCode = "98765",
                    Interests = new List<Interest>() { new Interest() {Name = "Programming" }, new Interest() { Name = "Mountain Bike Riding"} } },
                new Person() { Address1 = "123 Bremerton Way", Address2 = "Apt 456", State = "WA", Country = "USA", City = "Leavenworth",
                    BirthDate = new DateTime(1958, 6, 5), GivenName = "BraydenTest", FamilyName = "Baitester", MiddleName = "J", PostalCode = "98765",
                    Interests = new List<Interest>() { new Interest() {Name = "Blogging" }, new Interest() { Name = "Chess" } } },
                new Person() { Address1 = "123 Tacoma Way", Address2 = "Apt 456", State = "WA", Country = "USA", City = "White Salmon",
                    BirthDate = new DateTime(2000, 4, 25), GivenName = "Betsy", FamilyName = "Estty", MiddleName = "J", PostalCode = "98765",
                    Interests = new List<Interest>() { new Interest() {Name = "Cross Training" } } },
                new Person() { Address1 = "123 Fife Way", Address2 = "Apt 456", State = "WA", Country = "USA", City = "Lynwood",
                    BirthDate = new DateTime(1998, 5, 5), GivenName = "Brenda", FamilyName = "Brenda", MiddleName = "J", PostalCode = "98765",
                    Interests = new List<Interest>() { new Interest() {Name = "Surgery" }, new Interest() { Name = "Trips to Mars" } } }
            };

            context.People.AddRange(peoples);
            context.SaveChanges();
        }
    }
}
