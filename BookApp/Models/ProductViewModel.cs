using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    public class ProductViewModel
    {
        public List<Book> Books { get; set;} = null!;
        public List<Category> Categories{ get; set; } = null!;
        public string? SelectedCategory { get; set; }
    }
}