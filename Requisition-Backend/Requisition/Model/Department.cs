using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Requisition.Model
{
	[Table("tbl_department")]
	public class Department
	{
		[Key]
		public int ID { get; set; }

		public string DepartmentName { get; set; }
	}
}
