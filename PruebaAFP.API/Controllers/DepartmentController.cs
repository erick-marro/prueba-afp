using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaAFP.API.Services.Departments;
using PruebaAFP.Contracts.Departments;

namespace PruebaAFP.API.Controllers
{
    [Route("api/departments")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {

        public readonly IDepartmentService _service;

        public DepartmentController(
            IDepartmentService service) 
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateDepartmentRequest request)
        {
            var department = await _service.CreateDepartment(request);

            if (department != null)
            {
                return Ok(department);
            }

            return BadRequest();
        }
    }
}
