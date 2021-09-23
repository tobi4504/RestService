using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLib;
using RestService.Manager;

namespace RestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController
    {
        private IBooksController mgr = new ManageBooks();



        
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return mgr.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Book Get(int id)
        {
            return mgr.Get(id);
        }


        [HttpGet]
        [Route("Name/{name}")]
        public Book Get(string name)
        {
            return mgr.GetName(name);
        }

        //[HttpGet]
        //[Route("search")]
        //public IEnumerable<Book> Search([FromQuery] BookFilter filter)
        //{
        //    return mgr.Search(filter);
        //}

        
        [HttpPost]
        public bool Post([FromBody] Book value)
        {
            return mgr.Create(value);
        }

       
        [HttpPut]
        [Route("{id}")]
        public bool Put(int id, [FromBody] Book value)
        {
            return mgr.Update(id, value);
        }

        
        [HttpDelete]
        [Route("{id}")]
        public Book Delete(int id)
        {
            return mgr.Delete(id);
        }
    }
}
