using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    public class Repository
    {
        private static readonly List<Book> _books = new();
        private static readonly List<Category> _categories = new();

        static Repository(){
            _categories.Add(new Category{Id=1,Name="Roman"});
            _categories.Add(new Category{Id=2,Name="Hikaye"});

            _books.Add(new Book{BookId=1,Title="Son Ayı",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",Image="1.png",Price = 150,IsActive=true,CategoryId=1});
            _books.Add(new Book{BookId=2,Title="Roman Dünyası",Description="Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",Image="2.png",Price = 180,IsActive=true,CategoryId=1});
            _books.Add(new Book{BookId=3,Title="Cadı",Description="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",Image="3.png",Price = 280,IsActive=true,CategoryId=2});
        }

        public static List<Book> Books{
            get{
                return _books;
            }
        }

        public static void CreateProduct(Book entity){
            _books.Add(entity);
        }

        public static List<Category> Categories{
            get{
                return _categories;
            }
        }
    }
}