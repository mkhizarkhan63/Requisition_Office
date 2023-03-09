using Requisition.Context;
using Requisition.IRepository;
using Requisition.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Requisition.Model.DTO;
using Microsoft.EntityFrameworkCore;

namespace Requisition.Repository
{
	public class AccountUserRepo : IAccountUserRepository
	{
		private readonly APIDbContext _context;
		public AccountUserRepo(APIDbContext context)
		{
			_context = context;
		}
		public async Task<bool> Add(User entity)
		{
			try
			{
				if (entity != null)
				{
					var isUsr = await _context.Users.FirstOrDefaultAsync(x => x.Username.ToLower() == entity.Username.ToLower());
					if (isUsr != null)
					{
						await _context.Users.AddAsync(entity);
						return true;
					}
					else
					{
						return false;
					}

				}
				else
				{
					return false;
				}
			}
			catch (System.Exception ex)
			{

				throw ex;
			}

		}


		public Task<bool> Delete(User entity)
		{
			throw new System.NotImplementedException();
		}

		public Task<User> Get(int id)
		{
			throw new System.NotImplementedException();
		}

		public async Task<IEnumerable<User>> GetAll()
		{
			//var query = await (from emp in _context.Employees
			//				   join dept in _context.Departments on emp.dept_Id equals dept.ID
			//				   join desig in _context.Designations on emp.desig_Id equals desig.ID
			//				   join emprole in _context.Employee_Roles on emp.ID equals emprole.Emp_Id
			//				   join rol in _context.Roles on emprole.Role_Id equals rol.ID
			//				   select new AccountUser
			//				   {
			//					   empId = emp.ID,
			//					   empName = emp.Name,
			//					   roleName = rol.RoleName,
			//					   deptName = dept.DepartmentName,
			//					   desigName = desig.DesignationName
			//				   }
			//				   ).ToListAsync();
			try
			{
				var users = await _context.Users.ToListAsync();
				return users;
			}
			catch (System.Exception ex)
			{

				throw ex;
			}


		}

		public Task<bool> Update(User entity)
		{
			throw new System.NotImplementedException();
		}

		public async Task<User> GetByUsername(string username)
		{
			try
			{
				var user = await _context.Users.FirstOrDefaultAsync(x => x.Username.ToLower() == username.ToLower());
				return user;
			}
			catch (System.Exception ex)
			{

				throw ex;
			}
		}


	}
}
