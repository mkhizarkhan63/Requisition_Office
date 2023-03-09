using Requisition.Context;
using Requisition.IRepository;
using System;

namespace Requisition.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly APIDbContext _context;

		public IDepartmentRepository DepartmentsRepo { get; }

		public IRolesRepository RolesRepo { get; }
		public IAccountUserRepository AccountUserRepo { get; }

		public UnitOfWork(APIDbContext context, IDepartmentRepository departmentsRepository,
			IAccountUserRepository accountUserRepo , IRolesRepository rolesRepository
			)
		{
			this._context = context;
			this.DepartmentsRepo = departmentsRepository;
			this.AccountUserRepo = accountUserRepo;
			this.RolesRepo = rolesRepository;
		}

		public int Complete()
		{
			return _context.SaveChanges();
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				_context.Dispose();
			}
		}
	}
}
