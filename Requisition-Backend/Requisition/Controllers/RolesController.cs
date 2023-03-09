using Microsoft.AspNetCore.Mvc;
using Requisition.Context;
using Requisition.IRepository;
using Requisition.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Requisition.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RolesController : ControllerBase
	{
		private readonly IUnitOfWork _unitOfWork;
		public RolesController(IUnitOfWork unitOfWork)
		{
			this._unitOfWork = unitOfWork;
		}
		// GET: api/<RolesController>
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			try
			{
				var roles = await _unitOfWork.RolesRepo.GetAll();
				return Ok(roles);
			}
			catch (System.Exception ex)
			{

				throw;
			}
		}

		// GET api/<RolesController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<RolesController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<RolesController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<RolesController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
