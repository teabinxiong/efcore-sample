using EFCore5WebApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace EFCore5WebApp.DAL.Tests
{
    [TestFixture]
    public class SelectTests
    {
        private AppDbContext _context;

        [SetUp]
        public void Setup()
        {
            var dbContextOptions = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer("Server=PC-20210111AZGK\\DOMOCI;Database=EfCore5WebApp;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;
            _context = new AppDbContext(dbContextOptions);
        }


        [Test]
        public void GetAllPersons()
        {
            IEnumerable<Person> persons = _context.Persons.ToList();
            var actual = 2;
            Assert.That(actual, Is.EqualTo(persons.Count()));
        }

        [Test]
        public void PersonsHaveAddresses()
        {
            List<Person> persons = _context.Persons.Include("Addresses").ToList();
            var actualFirstPersonAddress = 1;
            var actualSecondPersonAddress = 2;
            Assert.That(actualFirstPersonAddress, Is.EqualTo(persons[0].Addresses.Count));
            Assert.That(actualSecondPersonAddress, Is.EqualTo(persons[1].Addresses.Count));
        }

        [Test]
        public void HaveLookUpRecords()
        {
            var lookUps = _context.LookUps.ToList();
            var countries = lookUps.Where(x => x.LookUpType == LookUpType.Country).ToList();
            var states = lookUps.Where(x => x.LookUpType == LookUpType.State).ToList();

            var actualCountriesCount = 1;
            var actualStatesCount = 51;

            Assert.That(actualCountriesCount, Is.EqualTo(countries.Count));
            Assert.That(actualStatesCount, Is.EqualTo(states.Count));
        }
    }
}