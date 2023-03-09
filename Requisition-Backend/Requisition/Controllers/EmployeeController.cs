using Microsoft.AspNetCore.Mvc;
using Requisition.IRepository;
using Requisition.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Requisition.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		private readonly IUnitOfWork _unitOfWork;
		public EmployeeController(IUnitOfWork unitOfWork)
		{
			this._unitOfWork = unitOfWork;
		}
		// GET: api/<EmployeeController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<EmployeeController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<EmployeeController>
		[HttpPost]
		public async Task<IActionResult> Post([FromBody] User obj)
		{
		

			return Ok();
		}

		// PUT api/<EmployeeController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<EmployeeController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
