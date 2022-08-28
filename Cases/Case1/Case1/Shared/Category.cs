using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1.Shared
{
    //https://stackoverflow.com/a/64401612/12878692
    public class Category
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Title { get; set; }
    }

    public static class CategoryHelpers
    {
        public static IEnumerable<Category> Categories = new[]
        {
            new Category { ParentId = 0, Id = 1, Title = "Computer" },
            new Category { ParentId = 0, Id = 2, Title = "Software" },
            new Category { ParentId = 2, Id = 3, Title = "Programming Languages" },
            new Category { ParentId = 1, Id = 4, Title = "Hardware" },
            new Category { ParentId = 1, Id = 9, Title = "Useware" },
            new Category { ParentId = 4, Id = 10, Title = "Javascript" },
            new Category { ParentId = 3, Id = 11, Title = "Blazor" },
            new Category { ParentId = 2, Id = 12, Title = "C#" },
        };
    }
}
