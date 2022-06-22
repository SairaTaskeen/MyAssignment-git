
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyAssignment.Repositories;
using MyAssignment.Services;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyAssignment.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : class
    {
        protected IService<T> services;
        public BaseController(IService<T> repo)
        {
            this.services = repo;
        }
        // GET: api/<BaseController>
        [HttpGet]
        public ICollection<T> Get()
        {

            var data = services.Get().ToList();
            return data;
        }

        // GET api/<BaseController>/5
        [HttpGet("{id}")]
        public T Get(int id) 
        {
            var item = services.Get(id);
            return item;
        }

        // POST api/<BaseController>
        [HttpPost]
        public bool Post([FromBody] T value)
        {
           var dataToPost= services.Add(value);
            return dataToPost;
        }

        // PUT api/<BaseController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] T value)
        {
            var itemToUpdate = services.Update(value);
            return itemToUpdate;
        }

        // DELETE api/<BaseController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var itemTodelete= services.Delete(id);
            return itemTodelete;
        }
    }
}
