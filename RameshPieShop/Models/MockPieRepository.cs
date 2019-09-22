using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RameshPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitializesPies();
            }
        }

        private void InitializesPies()
        {
            _pies = new List<Pie>
            {
                new Pie {Id = 1, Name = "Apple Pie", Price = 12.9M, ShortDescription="Our famous apple pies!", LongDescription="Icing carrot jelly-o cheesecake. Sweet roll marziepie"},
                new Pie {Id = 2, Name = "Blueberry Cheese Cake", Price = 18.5M, ShortDescription="You'll love it!", LongDescription="Icing carrot jelly-o cheesecake. Sweet roll marziepie"},
                new Pie {Id = 3, Name = "Cheese Cake", Price = 18.95M, ShortDescription="Plain cheese cake. Plain Pleasure.", LongDescription="Icing carrot jelly-o cheesecake. Sweet roll marziepie"},
                new Pie {Id = 4, Name = "Cherry Pie", Price = 15.95M, ShortDescription="A summer classic!", LongDescription="Icing carrot jelly-o cheesecake. Sweet roll marziepie"}
            };
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
