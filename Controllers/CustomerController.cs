using CustomerManagmentProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerManagmentProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        IRepo<Customer> _repo;
        public CustomerController(IRepo<Customer> repo)
        {
            _repo = repo;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            try
            {
                var customers = _repo.GetItems();
                return Ok(customers);
            }
            catch (Exception e)
            {
                return BadRequest("erroe" + e.Message);
            }
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult<Customer> Post([FromBody] Customer value)
        {
            try
            {
                _repo.AddItem(value);
                return Ok(value);
            }
            catch (Exception e)
            {
                return BadRequest("erroe" + e.Message);
            }        
        }
    }
}
