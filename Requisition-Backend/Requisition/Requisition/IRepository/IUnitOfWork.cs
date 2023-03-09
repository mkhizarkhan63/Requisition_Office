using System;

namespace Requisition.IRepository
{
	public interface IUnitOfWork : IDisposable
	{
		IDepartmentRepository DepartmentsRepo { get; }
		IAccountUserRepository AccountUserRepo { get; }
		IRolesRepository RolesRepo { get; }
		int Complete();
	}
}
