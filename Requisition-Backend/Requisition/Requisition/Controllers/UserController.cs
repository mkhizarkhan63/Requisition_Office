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
	public class UserController : ControllerBase
	{

		private readonly IUnitOfWork _unitOfWork;
		public UserController(IUnitOfWork unitOfWork)
		{
			this._unitOfWork = unitOfWork;
		}

		// GET: api/<UserController>
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			try
			{
				var ls = await _unitOfWork.AccountUserRepo.GetAll();
				return Ok(ls);
			}
			catch (System.Exception ex)
			{

				throw ex;
			}

		}

		// GET api/<UserController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<UserController>
		[HttpPost]
		public async Task<IActionResult> Post([FromBody] User obj)
		{
			try
			{
				var result = _unitOfWork.AccountUserRepo.Add(obj);
				var response = _unitOfWork.Complete();
				if (response > 0)
				{
					return Ok("Added Successfully");
				}
				else
				{
					return Ok("Already Exists");
				}

			}
			catch (System.Exception ex)
			{

				throw ex;
			}
		}

		//public async Task<IActionResult> CreateRoles([FromBody] Employee_Roles obj)
		//{
		//	try
		//	{

		//	}
		//	catch (System.Exception ex)
		//	{
		//		throw ex;
		//	}

		//}



		// PUT api/<UserController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<UserController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
