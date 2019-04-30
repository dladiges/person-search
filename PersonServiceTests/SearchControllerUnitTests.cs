using Moq;
using NUnit.Framework;
using PersonData;
using PersonService.Controllers;
using System.Collections.Generic;
using System.Diagnostics;

namespace PersonService.Tests
{
    [TestFixture]
    public class SearchControllerUnitTests
    {
        [Test]
        public void SearchIsDelayed()
        {
            // Arrange controller to test
            var people = new List<Person>
            {
                new Person { GivenName = "Test", FamilyName = "NotMatched" },
                new Person { GivenName = "Testing", FamilyName = "NotMatched" },
                new Person { GivenName = "Test", FamilyName = "Test" },
                new Person { GivenName = "NotMatched", FamilyName = "test" }
            };

            var mockSearchService = new Mock<ISearchService>();
            mockSearchService.Setup(s => s.SearchPeople("test", 10)).Returns(people);

            var searchController = new SearchController(mockSearchService.Object);

            var stopwatch = Stopwatch.StartNew();
            var timedResult = searchController.Search("test", 10, 2);
            stopwatch.Stop();

            var secondsElapsed = stopwatch.ElapsedMilliseconds / 1000;

            // Assert mimimum time has elapsed
            Assert.IsTrue(secondsElapsed >= 2);
        }
    }
}
