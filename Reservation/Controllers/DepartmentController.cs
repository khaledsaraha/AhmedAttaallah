using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Reservation.Controllers.Base;
using Service;

namespace Reservation.Controllers
{
    
    public class DepartmentController : BaseController
    {
        private readonly DepartmentService _service;
        public DepartmentController(Context context)
        {
            _service = new DepartmentService(context);
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