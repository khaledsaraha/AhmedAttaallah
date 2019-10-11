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
    public class DepartmentController : ControllerBase
    {
        private readonly DepartmentService service;
        public DepartmentController(Context context)
        {
            service = new DepartmentService(context);
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
        public IActionResult Add(Department department)
        {
            service.Add(department);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(Department department)
        {
            service.Update(department);
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