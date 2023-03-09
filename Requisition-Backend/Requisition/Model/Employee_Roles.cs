using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Requisition.Model
{
	[Table("tbl_employeeRoles")]
	public class Employee_Roles
	{
		[Key]
		public int ID { get; set; }
		public int Emp_Id { get; set; }
		public int Role_Id { get; set; }
	}
}
