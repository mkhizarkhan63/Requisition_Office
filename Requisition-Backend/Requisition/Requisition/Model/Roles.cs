using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Requisition.Model
{
	[Table("tbl_roles")]
	public class Roles
	{
		[Key]
		public int ID { get; set; }

		public string RoleName { get; set; }

	}
}
