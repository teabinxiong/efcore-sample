using EFCore5WebApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCore5WebApp.DAL.Tests
{
    public class UpdateTests
    {
        private AppDbContext _context;
        private int _personId;

        [SetUp]
        public void SetUp()
        {
            _context = new AppDbContext(new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer("Server=PC-20210111AZGK\\DOMOCI;Database=EfCore5WebApp;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options);

            var record = new Core.Entities.Person()
            {
                FirstName = "Clarke",
                LastName = "Kent",
                CreatedOn = DateTime.Now,
                EmailAddress = "clark@daileybugel.com",
                Addresses = new List<Address>
                {
                    new Address
                    {
                        AddressLine1 = "1234 Fake Street",
                        AddressLine2 = "Suite 1",
                        City = "Chicago",
                        State = "IL",
                        ZipCode = "60652",
                        Country = "United States"
                    },
                }
            };
            _context.Persons.Add(record);
            _context.SaveChanges();
            _personId = record.Id;
        }


        [Test]
        public void UpdatePersonWithAddresses()
        {
            var person = _context.Persons.Single(x => x.Id == _personId);
            string firstName = "Matt";
            string lastName = "Smith";
            string email = "doctor@who.com";
            person.FirstName = firstName;
            person.LastName = lastName;
            person.EmailAddress = email;
            var address = person.Addresses.First();
            string addressLine1 = "123 Update St";
            string addressLine2 = "APT B1";
            string city = "Okemos";
            string state = "MI";
            string country = "USA";
            string zipCode = "48864";
            address.AddressLine1 = addressLine1;
            address.AddressLine2 = addressLine2;
            address.City = city;
            address.State = state;
            address.Country = country;
            address.ZipCode = zipCode;
            _context.SaveChanges();
            var updatedPerson = _context.Persons.Single(x => x.Id == _personId);
            Assert.AreEqual(1, updatedPerson.Addresses.Count);
            Assert.AreEqual(firstName, updatedPerson.FirstName);
            Assert.AreEqual(lastName, updatedPerson.LastName);
            Assert.AreEqual(email, updatedPerson.EmailAddress);
            var updatedAddress = updatedPerson.Addresses.First();
            Assert.AreEqual(addressLine1, updatedAddress.AddressLine1);
            Assert.AreEqual(addressLine2, updatedAddress.AddressLine2);
            Assert.AreEqual(city, updatedAddress.City);
            Assert.AreEqual(state, updatedAddress.State);
            Assert.AreEqual(zipCode, updatedAddress.ZipCode);
            Assert.AreEqual(country, updatedAddress.Country);
        }
    }
}

