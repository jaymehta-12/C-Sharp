using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTEST
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Jay",
                LastName = "Mehta"
            };

            string expected = "Mehta, Jay";

            //-- Act
            string actual = customer.FullName;

            //--Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
