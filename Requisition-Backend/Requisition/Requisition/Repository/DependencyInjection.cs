using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Requisition.Context;
using Requisition.IRepository;

namespace Requisition.Repository
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddRepository(this IServiceCollection services)
		{
			services.AddTransient<IDepartmentRepository, DepartmentRepository>();
			services.AddTransient<IAccountUserRepository, AccountUserRepo>();
			services.AddTransient<IRolesRepository, RolesRepository>();
			services.AddTransient<IUnitOfWork, UnitOfWork>();

			return services;
		}
	}
}
