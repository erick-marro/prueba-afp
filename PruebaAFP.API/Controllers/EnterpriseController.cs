using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaAFP.API.Services.Departments;
using PruebaAFP.API.Services.Enterprises;
using PruebaAFP.Contracts.Enterprises;

namespace PruebaAFP.API.Controllers
{
    [ApiController]
    [Route("api/enterprises")]
    public class EnterpriseController : ControllerBase
    {

        private readonly IEnterpriseService _service;
        private readonly IDepartmentService _departments;

        public EnterpriseController(
            IEnterpriseService service,
            IDepartmentService department) {
            _service = service;
            _departments = department;
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateEnterpriseRequest request)
        {
            var enterprise = await _service.CreateEnterprise(request);
            if (enterprise != null)
            {
                return Ok(enterprise);
            }

            return BadRequest();
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var enterprise = await _service.GetEnterprise(id);

            if (enterprise != null)
            {
                return Ok(enterprise);
            }

            return NotFound();
        }

        [HttpGet("{id:guid}/departments")]
        public async Task<IActionResult> GetDepartments(Guid id)
        {
            var departments = await _departments.GetByEnterprise(id);
            if (departments != null)
            {
                return Ok(departments);
            }

            return Ok("No results");
        }
    }
}
