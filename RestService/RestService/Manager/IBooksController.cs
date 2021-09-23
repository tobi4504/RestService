using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ModelLib;

namespace RestService.Manager
{
    public interface IBooksController
    {
        public IEnumerable<Book> Get();
        public Book Get(int id);
        public bool Create(Book value);
        public Book Delete(int id);
        public bool Update(int id, [FromBody] Book value);
        //IEnumerable<Book> GetFromSubstring(String substring);
        //IEnumerable<Book> GetBookAuthor(string quary);

         Book GetName(string name);
        // public IEnumerable<Book> GetWithFilter(FilterItem filter);
    }
}
