using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Reservation.Controllers.Base;
using Service.Services;

namespace Reservation.Controllers
{
    public class EmployeeController : BaseController
    {
        private readonly EmployeeService _service;
        public EmployeeController(Context context)
        {
            _service = new EmployeeService(context);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.Get(id));
        }
        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            _service.Add(employee);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(Employee employee)
        {
            _service.Update(employee);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
    
}