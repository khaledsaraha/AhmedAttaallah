using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Reservation.Controllers.Base;
using Service;

namespace Reservation.Controllers
{
    public class BranchController : BaseController
    {
        private readonly BranchService _service;
        public BranchController(Context context)
        {
            _service = new BranchService(context);
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
        public IActionResult Add(Branch branch)
        {
            _service.Add(branch);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(Branch branch)
        {
            _service.Update(branch);
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