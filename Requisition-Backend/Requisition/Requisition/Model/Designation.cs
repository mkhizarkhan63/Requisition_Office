using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Requisition.Model
{
	[Table("tbl_designation")]
	public class Designation
	{
		[Key]
		public int ID { get; set; }
		public string DesignationName { get; set; }
	}
}
