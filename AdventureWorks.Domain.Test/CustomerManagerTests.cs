using AdventureWorks.Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AdventureWorks.Domain.Test
{
    [TestClass]
    public class CustomerManagerTests
    {
        [TestMethod]
        public void TestGetCustomer()
        {
            // ARRANGE
            CustomerManager cm = new CustomerManager();

            // ACT
            Customer c = cm.GetCustomer(29546);

            // ASSERT
            Assert.IsNotNull(c);
            Assert.AreEqual("Christopher", c.FirstName);
            Assert.AreEqual("Beck", c.LastName);
        }

        [TestMethod]
        public void TestSearchCustomers()
        {
            // ARRANGE
            CustomerManager cm = new CustomerManager();

            // ACT
            IList<Customer> customers = cm.SearchCustomers("Lucy");

            // ASSERT
            Assert.IsNotNull(customers);
            Assert.IsTrue(customers.Count > 0);
        } 
    }
}
