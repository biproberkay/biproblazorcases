using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1.Shared
{
    //https://stackoverflow.com/a/64401612/12878692
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }

    public static class ProductHelpers
    {
        public static IEnumerable<Product> Products = new[]
        {
            new Product { Id = 1, CategoryId = 1, Name = "Asus N56VZ" },
            new Product { Id = 2, CategoryId = 2, Name = "Tandem" },
            new Product { Id = 3, CategoryId = 4, Name = "MSI Mainbord" },
            new Product { Id = 4, CategoryId = 9, Name = "Photoshop Skill Course" },
            new Product { Id = 5, CategoryId = 3, Name = "Ruby" },
            new Product { Id = 6, CategoryId = 12, Name = ".NET6" },
            new Product { Id = 7, CategoryId = 11, Name = "Mudblazor" },
            new Product { Id = 8, CategoryId = 10, Name = "React" },
        };
    }
}
