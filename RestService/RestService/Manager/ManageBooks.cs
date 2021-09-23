using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLib;

namespace RestService.Manager
{
    public class ManageBooks : IBooksController
    {
        private static readonly List<Book> books = new List<Book>()
        {
            new Book(1,"Lord of the rings", 1992, "J.k Rowling", 22, 100),
            new Book(2,"Harry Potter and some stones",1998,"Tolken",23,30),
            new Book(3,"The little mermaid",2003,"Dan Brown",200,11),
            new Book(4,"Infernal",1992,"H.C Andersen",2211,1000),
        };
        public bool Create([FromBody] Book value)
        {
            books.Add(value);
            return true;
        }

        public Book Delete(int id)
        {
            Book book = Get(id);
            books.Remove(book);
            return book;

        }

        public IEnumerable<Book> Get()
        {
            return new List<Book>(books);
        }

        public Book Get(int id)
        {
            if (books.Exists(i => i.Id == id))
            {
                return books.Find(i => i.Id == id);
            }
            throw new KeyNotFoundException();
        }
        public Book GetName(string name)
        {
            if (books.Exists(i => i.Name == name))
            {
                return books.Find(i => i.Name == name);
            }
            throw new KeyNotFoundException();
        }

        public bool Update(int id, [FromBody] Book value)
        {
            Book item = Get(id);
            if (item != null)
            {
                item.Id = value.Id;
                item.Name = value.Name;
                item.Amount = value.Amount;
                item.Price = value.Price;
                item.Author = value.Author;
                item.Year = value.Year;
                return true;
            }
            return false;
        }

        public IEnumerable<Book> GetFromSubstring(String substring)
        {
            return books.Where(i => i.Name.Contains(substring));
        }

        public IEnumerable<Book> GetBookAuthor(string quary)
        {
            return books.Where(i => i.Author.Contains(quary));
        }

        //public IEnumerable<Book> GetWithFilter(ModelLib.FilterItem filter)
        //{
        //    double min = filter.LowQuantity;
        //    double max = (filter.HighQuantity == 0) ? Double.MaxValue : filter.HighQuantity;
        //    return items.Where(p => min <= p.AmountQuantity && p.AmountQuantity <= max);
        //}
    }
}
