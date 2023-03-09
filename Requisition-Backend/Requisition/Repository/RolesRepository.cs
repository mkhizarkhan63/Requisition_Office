using Microsoft.EntityFrameworkCore;
using Requisition.Context;
using Requisition.IRepository;
using Requisition.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Requisition.Repository
{
	public class RolesRepository : IRolesRepository
	{
		private readonly APIDbContext _context;
		public RolesRepository(APIDbContext context)
		{
			_context = context;
		}
		public Task<bool> Add(Roles entity)
		{
			throw new System.NotImplementedException();
		}

		public Task<bool> Delete(Roles id)
		{
			throw new System.NotImplementedException();
		}

		public Task<Roles> Get(int id)
		{
			throw new System.NotImplementedException();
		}

		public async Task<IEnumerable<Roles>> GetAll()
		{
			try
			{
				var ls = await _context.Roles.ToListAsync();
				return ls;
			}
			catch (System.Exception ex)
			{

				throw ex;
			}

		}

		public Task<bool> Update(Roles entity)
		{
			throw new System.NotImplementedException();
		}
	}
}
