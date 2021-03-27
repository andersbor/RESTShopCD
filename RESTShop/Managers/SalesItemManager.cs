using System.Collections.Generic;
using System.Linq;
using RESTShop.Models;

namespace RESTShop.Managers
{
    public class SalesItemManager
    {
        private static int _nextId = 1;
        private static readonly List<SalesItem> Data = new List<SalesItem>
        {
            new SalesItem {Id=_nextId++, Name = "Pencil", Price = 8.5, Quantity = 14},
            new SalesItem {Id=_nextId++, Name = "Cup", Price = 34.7, Quantity = 4},
            new SalesItem { Id=_nextId++, Name="Glasses", Price=1234, Quantity = 1},
            new SalesItem {Id=_nextId++, Name ="Ink", Price=499, Quantity = 2}
        };

        public List<SalesItem> GetAll()
        {
            return new List<SalesItem>(Data);
        }

        public SalesItem GetById(int id)
        {
            return Data.FirstOrDefault(item => item.Id == id);
        }

        public SalesItem Add(SalesItem newItem)
        {
            newItem.Id = _nextId++;
            Data.Add(newItem);
            return newItem;
        }
    }
}
