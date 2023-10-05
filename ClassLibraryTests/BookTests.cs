using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ClassLibrary.Tests
{
    [TestClass()]
    public class BookTests
    {
        [TestMethod()]
        [DataRow("Hawaii")]
        [DataRow("Abefest")]
        public void TitleOkTest(String value)
        {
            Book book = new Book();
            string expectedTitle = value;

            book.Title = value;
            string actualTitle = book.Title;

            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [TestMethod()]
        [DataRow("Ha")]
        [DataRow("Ab")]
        public void TitleFailTest(String value)
        {
            Book book = new Book();

            Assert.ThrowsException<ArgumentException>(()=>book.Title = value);
        }

        [TestMethod()]
        [DataRow(null)]
        public void TitleFailTest2(String value)
        {
            Book book = new Book();

            Assert.ThrowsException<ArgumentNullException>(() => book.Title = value);
        }

        [TestMethod()]
        [DataRow(-100)]
        [DataRow(2200)]
        public void PriceFailTest(double value)
        {
            Book book = new Book();

            Assert.ThrowsException<ArgumentException>(() => book.Price = value);
        }
    }
}