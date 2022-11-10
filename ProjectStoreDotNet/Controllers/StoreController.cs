using Microsoft.AspNetCore.Mvc;
using ProjectStoreDotNet.Models;
using ProjectStoreDotNet.Repository;

namespace ProjectStoreDotNet.Controllers
{
    [ApiController]
    [Route("/")]
    public class StoreController : Controller
    {
        private readonly IStoreRepository _repository;

        public StoreController(IStoreRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("department")]
        public IActionResult GetDepartment()
        {
            var department = _repository.GetDepartments();
            return Ok(department);
        }

        [HttpGet("department/{id}")]
        public IActionResult GetDepartmentById(int id)
        {
            var department = _repository.GetDepartmentById(id);
            return Ok(department);
        }

        [HttpDelete("department/{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            var department = _repository.GetDepartmentById(id);
            if (department == null)
            {
                return NotFound();
            }
            _repository.DeleteDepartment(department);
            return Ok(_repository.GetDepartments());
        }
        [HttpPost("department")]
        public IActionResult AddDepartment([FromBody]Department department)
        {
            _repository.AddDepartment(department);
            return StatusCode(201, department);
        }

        [HttpGet("seller")]
        public IActionResult GetSeller()
        {
            var seller = _repository.GetSellers();
            return Ok(seller);
        }

        [HttpGet("seller/{id}")]
        public IActionResult GetSellerById(int id)
        {
            var seller = _repository.GetSellerById(id);
            return Ok(seller);
        }

        [HttpDelete("seller/{id}")]
        public IActionResult DeleteSeller(int id)
        {
            var seller = _repository.GetSellerById(id);
            if (seller == null)
            {
                return NotFound();
            }
            _repository.DeleteSeller(seller);
            return Ok(_repository.GetSellers());
        }
        [HttpPost("seller")]
        public IActionResult AddSeller([FromBody] Seller seller)
        {
            _repository.AddSeller(seller);
            return StatusCode(201, seller);
        }
    }
}
