using Microsoft.VisualStudio.TestTools.UnitTesting;
using RESTShop.Managers;
using System;
using System.Collections.Generic;
using System.Text;
using RESTShop.Models;

namespace RESTShop.Managers.Tests
{
    [TestClass]
    public class SalesItemManagerTests
    {
        private readonly SalesItemManager _manager = new SalesItemManager();

        [TestMethod]
        public void GetAllTest()
        {
            List<SalesItem> allItems = _manager.GetAll();
            Assert.AreEqual(2, allItems.Count);

            SalesItem item = _manager.GetById(1);
            Assert.IsNotNull(item);
            Assert.AreEqual(1, item.Id);

            item = _manager.GetById(0);
            Assert.IsNull(item);

            SalesItem newItem = new SalesItem() { Name = "Bottle", Price = 1.0, Quantity = 45 };

            SalesItem it = _manager.Add(newItem);
            Assert.AreEqual(it.Name, newItem.Name);

            allItems = _manager.GetAll();
            Assert.AreEqual(3, allItems.Count);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddTest()
        {
            Assert.Fail();
        }
    }
}