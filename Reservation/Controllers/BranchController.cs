using Entities;
using Microsoft.AspNetCore.Mvc;
using Reservation.Controllers.Base;
using Service.Dto;
using Service.Interface;

namespace Reservation.Controllers
{
    public class BranchController : BaseController
    {
        private readonly IBranchService _service;
        public BranchController(IBranchService service)
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
        public IActionResult Add(BranchDto branch)
        {
            _service.Add(branch);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(BranchDto branch)
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