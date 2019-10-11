using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Service;

namespace Reservation.Controllers
{
    [Route("[controller]/[action]")] 
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService service;
        public EmployeeController(Context context)
        {
            service = new EmployeeService(context);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(service.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.Get(id));
        }
        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            service.Add(employee);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(Employee employee)
        {
            service.Update(employee);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            service.Delete(id);
            return Ok();
        }
    }
    
}