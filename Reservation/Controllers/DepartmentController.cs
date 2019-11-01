using Entities;
using Microsoft.AspNetCore.Mvc;
using Reservation.Controllers.Base;
using Service.Interface;

namespace Reservation.Controllers
{

    public class DepartmentController : BaseController
    {
        private readonly IDepartmentService _service;
        public DepartmentController(IDepartmentService service)
        {
            _service = service;
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
        public IActionResult Add(Department department)
        {
            _service.Add(department);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(Department department)
        {
            _service.Update(department);
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