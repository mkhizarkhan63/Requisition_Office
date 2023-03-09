using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Requisition.Model
{
	[Table("tbl_employee")]
	public class Employee
	{
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }
		public int dept_Id { get; set; }
		public int desig_Id { get; set; }
	}
}
