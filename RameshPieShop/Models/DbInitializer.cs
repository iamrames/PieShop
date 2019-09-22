using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RameshPieShop.Models
{
    public class DbInitializer
    {
        private readonly AppDbContext _context;

        public DbInitializer(AppDbContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if(!_context.Pies.Any())
            {
                _context.AddRange
                (
                    new Pie { Name = "Apple Pie", Price = 12.9M, ShortDescription = "Our famous apple pies!", LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marziepie" },
                    new Pie { Name = "Blueberry Cheese Cake", Price = 18.5M, ShortDescription = "You'll love it!", LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marziepie" },
                    new Pie { Name = "Cheese Cake", Price = 18.95M, ShortDescription = "Plain cheese cake. Plain Pleasure.", LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marziepie" },
                    new Pie { Name = "Cherry Pie", Price = 15.95M, ShortDescription = "A summer classic!", LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marziepie" },
                    new Pie { Name = "Christmans Apple Pie", Price = 12.9M, ShortDescription = "A Christmas Favorite!", LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marziepie" },
                    new Pie { Name = "Cranberry Pie", Price = 18.5M, ShortDescription = "Happy holiday with this pies!", LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marziepie" },
                    new Pie { Name = "Peach Pie", Price = 18.95M, ShortDescription = "Sweet as Peach.", LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marziepie" },
                    new Pie { Name = "Pumpkin Pie", Price = 15.95M, ShortDescription = "Our Hallowen Favorite!", LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marziepie" },
                    new Pie { Name = "Phubarb Pie", Price = 12.9M, ShortDescription = "My God, So Sweet!", LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marziepie" },
                    new Pie { Name = "Strawberry Pie", Price = 18.5M, ShortDescription = "Our delicious strawberry pie!", LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marziepie" },
                    new Pie { Name = "Strawberry Cheese Cake", Price = 18.95M, ShortDescription = "You'll love it.", LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marziepie" },
                    new Pie { Name = "Pineapple Cake", Price = 15.95M, ShortDescription = "PPAP!", LongDescription = "Icing carrot jelly-o cheesecake. Sweet roll marziepie" }
                );

                _context.SaveChanges();
            }
        }
    }
}
