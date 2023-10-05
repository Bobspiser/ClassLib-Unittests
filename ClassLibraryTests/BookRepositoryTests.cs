using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Numerics;

namespace ClassLibrary.Tests
{
    [TestClass()]
    public class BookRepositoryTests
    {
        private static BookRepository? _tests = null;

        [TestMethod()]
        public void GetAllBooksTest(int value)
        {
            BookRepository Br = new BookRepository();

        }

        [TestMethod()]
        public void GetFilterPriceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetSortTPTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddTest()
        {
            AddGetTest();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }

        public void AddGetTest()
        {

            List<Book> actors = _tests.GetAllBooks();

            //Assert: No need to test any further
            Assert.IsNotNull(actors);

            //Arrange
            Book book = new Book()
            {
                Title = "Test",
                Price = 194
            };

            //Act
            Book? actorReturned = _tests.Add(book);
            Book? actorFound = null;

            foreach (Book a in _tests.GetAllBooks())
            {
                if (a.Id == actorReturned.Id)
                {
                    actorFound = a;
                    break;
                }
            }

            //Assert
            Assert.IsNotNull(actorReturned);
            Assert.AreEqual("Test", actorReturned.Title);
            Assert.AreEqual(194, actorReturned.Price);

            Assert.IsNotNull(actorFound);
            Assert.AreEqual("Test", actorFound.Title);
            Assert.AreEqual(194, actorFound.Price);
        }
    }
}