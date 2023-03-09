using Microsoft.EntityFrameworkCore;
using Requisition.Context;
using Requisition.IRepository;
using Requisition.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Requisition.Repository
{
	public class DepartmentRepository : IDepartmentRepository
	{
		private readonly APIDbContext _context;
		public DepartmentRepository(APIDbContext context)
		{
			_context = context;
		}
		public Task<bool> Add(Department entity)
		{
			throw new System.NotImplementedException();
		}

		public Task<bool> Delete(Department entity)
		{
			throw new System.NotImplementedException();
		}

		public async Task<Department> Get(int id)
		{
			return await _context.Departments.FirstOrDefaultAsync(x => x.ID == id);
		}

		public async Task<IEnumerable<Department>> GetAll()
		{
			return await _context.Departments.ToListAsync();
		}

		public Task<bool> Update(Department entity)
		{
			throw new System.NotImplementedException();
		}
	}
}
