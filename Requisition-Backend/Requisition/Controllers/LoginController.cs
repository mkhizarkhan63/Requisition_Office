using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Requisition.IRepository;
using Requisition.Model;
using Requisition.Repository;
using System.Threading.Tasks;

namespace Requisition.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoginController : ControllerBase
	{
		private readonly IUnitOfWork _uof;
		public LoginController(IUnitOfWork unitOfWork)
		{
			_uof = unitOfWork;
		}

		[HttpPost]
		public async Task<IActionResult> Login([FromBody] User obj)
		{
			
			
			Response res = new Response();
			try
			{
				var Data = await _uof.AccountUserRepo.GetByUsername(obj.Username);
				if (Data != null)
				{
					if (obj.Username == Data.Username && obj.Password == Data.Password)
					{
						res.flag = true;
						res.message = "You have login successfully";
					}
					else
					{
						res.flag = false;
						res.message = "Login failed";
					}

				}
				return Ok(res);

			}
			catch (System.Exception ex)
			{

				throw ex;
			}
		}
	}
}
