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
        private object erro;

        public StoreController(IStoreRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Mostra todos os Departamentos
        /// </summary>
        /// <returns>Retorna todos os Departamentos</returns>
        [HttpGet("department")]
        public IActionResult GetDepartment()
        {
            var department = _repository.GetDepartments();
            return Ok(department);
        }

        /// <summary>
        /// Mostra o departamento do ID especifíco
        /// </summary>
        /// <param name="id">Id do Departamento</param>
        /// <returns>Retorna o Departamento que corresponde ao ID dado como parâmetro</returns>
        /// <response code="404">Não existe Departamento com Esse ID</response>
        [HttpGet("department/{id}")]
        public IActionResult GetDepartmentById(int id)
        {
            var department = _repository.GetDepartmentById(id);
            if (department == null)
            {
                return NotFound(erro = "Departamento não encontrado");
            }
            return Ok(department);
        }

        /// <summary>
        /// Deleta o Departamento pelo ID
        /// </summary>
        /// <param name="id">Id do Departamento</param>
        /// <returns>Não Possui Retorno</returns>
        /// <response code="404">Não existe Departamento com Esse ID</response>
        [HttpDelete("department/{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            var department = _repository.GetDepartmentById(id);
            if (department == null)
            {
                return NotFound(erro = "Departamento não encontrado");
            }
            _repository.DeleteDepartment(department);
            return Ok();
        }

        /// <summary>
        /// Cria um novo Departamento
        /// </summary>
        /// <remarks>
        /// Exemplo:
        ///
        ///     {
        ///        "name": "Departamento",
        ///     }
        ///
        /// </remarks>

        /// <returns>Retorna seu novo Departamento</returns>
        [HttpPost("department")]
        public IActionResult AddDepartment([FromBody]Department department)
        {
            _repository.AddDepartment(department);
            return StatusCode(201, department);
        }

        /// <summary>
        /// Mostra todos os Vendedores
        /// </summary>
        /// <returns>Retorna todos os Vendedores</returns>
        [HttpGet("seller")]
        public IActionResult GetSeller()
        {
            var seller = _repository.GetSellers();
            return Ok(seller);
        }

        /// <summary>
        /// Mostra o vendedor pelo ID
        /// </summary>
        /// <param name="id">Id do Vendedor</param>
        /// <returns>Retorna o Vendedor que corresponde ao ID dado como parâmetro </returns>
        /// <response code="404">Não existe Vendedor com Esse ID</response>
        [HttpGet("seller/{id}")]
        public IActionResult GetSellerById(int id)
        {
            var seller = _repository.GetSellerById(id);
            if(seller == null)
            {
                return NotFound(new {erro = "Vendedor não encontrado"});
            }
            return Ok(seller);
        }

        /// <summary>
        /// Deelta o vendedor pelo ID
        /// </summary>
        /// <param name="id">Id do Vendedor</param>
        /// <returns>Não Possui Retorno</returns>
        /// <response code="404">Não existe Vendedor com Esse ID</response>
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

        /// <summary>
        /// Cria um novo Vendedor
        /// </summary>
        /// <remarks>
        /// Exemplo:
        ///
        ///     {
        ///         "name": "nomeDoVendedor",
        ///         "email": "email@fake.com",
        ///         "birthDate": "2022-11-11",
        ///         "baseSalary": 1000.00,
        ///         "departmentId": 1,
        ///     }
        ///
        /// </remarks>

        /// <returns>Retorna seu novo Departamento</returns>
        [HttpPost("seller")]
        public IActionResult AddSeller([FromBody] Seller seller)
        {
            _repository.AddSeller(seller);
            return StatusCode(201, seller);
        }
    }
}
