using Microsoft.AspNetCore.Mvc;
using MyAssignment.Repositories;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase
    {
        protected IRepository<T> repo;
        public BaseController(IRepository<T> repo)
        {
            this.repo = repo;
        }
        // GET: api/<BaseController>
        [HttpGet]
        public ICollection<T> Get()
        {
            var data = repo.Get().ToList();
            return data;
        }

        // GET api/<BaseController>/5
        [HttpGet("{id}")]
        public T Get(int id)
        {
           var item=repo.Get(id);
            return item;
        }

        // POST api/<BaseController>
        [HttpPost]
        public bool Post([FromBody] T value)
        {
           var dataToPost= repo.Add(value);
            return dataToPost;
        }

        // PUT api/<BaseController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] T value)
        {
            var itemToUpdate = repo.Update(value);
            return itemToUpdate;
        }

        // DELETE api/<BaseController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var itemTodelete=repo.Delete(id);
            return itemTodelete;
        }
    }
}
