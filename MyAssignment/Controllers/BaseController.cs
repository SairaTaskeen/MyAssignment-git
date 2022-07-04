
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyAssignment.AuthenticationHandler;
using MyAssignment.Repositories;
using MyAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyAssignment.Controllers
{
    
  
    [Route("api/[controller]")]
    [ApiController]
    [ExceptionFilter]

    //  [AuthAttribute("Index", "Admin")]
    //or we can pass this attribute 
    //  [Authorize]


    public class BaseController<T> : ControllerBase where T : class
    {
        protected IService<T> services;
        protected ILogger logger;
        protected IMapper mapper;

        public BaseController(IService<T> repo, ILogger logger, IMapper mapper)
        {
            this.services = repo;
            this.logger = logger;
            this.mapper = mapper;
        }
     
        // GET: api/<BaseController>
        [HttpGet]
      
        public  ActionResult <ICollection<T>> Get()
        {
            try
            {
                var data = services.Get().ToList();
                var getMap = mapper.Map<ICollection<T>>(data);
                return Ok(getMap);
            }
            catch (Exception er)
            {

                logger.log(er.ToString());
                return null;
            }

            
        }

        // GET api/<BaseController>/5
        [HttpGet("{id}")]
        [AuthAttribute("Index", "Admin")]
        public ActionResult <T>Get(int id) 
        {
            try
            {
                var item = services.Get(id);
                var getMap=mapper.Map<T>(item);
                return Ok(getMap);
            }
            catch (Exception er)
            {

                logger.log(er.ToString());
                return null;
            }
           
        }

        // POST api/<BaseController>
        [HttpPost]
        public  ActionResult <bool> Post([FromBody] T value)
        {
            try
            {
                var dataToPost = services.Add(value);
                var postMap = mapper.Map<T>(dataToPost);
                return true;
            }
            catch (Exception er)
            {

                logger.log(er.ToString());
                return false;
            }
          
        }

        // PUT api/<BaseController>/5
        [HttpPut("{id}")]
        public ActionResult<bool>  Put(int id, [FromBody] T value)
        {
            try
            {
                var itemToUpdate = services.Update(value);
                var putMap = mapper.Map<T>(itemToUpdate);
                return true;
            }
            catch (Exception er) 
            {


                logger.log(er.ToString());
                return false;
            }
           
        }

        // DELETE api/<BaseController>/5
        [HttpDelete("{id}")]
        public ActionResult <bool>  Delete(int id)
        {
            try
            {
                var itemTodelete = services.Delete(id);
                var deleteMap = mapper.Map<T>(itemTodelete);
                return true;
            }
            catch (Exception er)
            {
                logger.log(er.ToString());
                return false;
            }
           
        }
    }
}

























































//  [AuthAttribute("Index", "Admin")]