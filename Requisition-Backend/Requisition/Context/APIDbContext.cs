using Microsoft.EntityFrameworkCore;
using Requisition.Model;

namespace Requisition.Context
{
	public class APIDbContext : DbContext
	{
		public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
		{ }

		public DbSet<Department> Departments
		{
			get;
			set;
		}
		public DbSet<Employee> Employees
		{
			get;
			set;
		}

		public DbSet<Designation> Designations { get; set; }

		public DbSet<Employee_Roles> Employee_Roles { get; set; }
		public DbSet<Roles> Roles { get; set; }
		public DbSet<RequisitionForm> RequisitionForms { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<RequisitionDetail> RequisitionDetails { get; set; }
	}
}
