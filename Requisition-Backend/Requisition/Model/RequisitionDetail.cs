using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Requisition.Model
{
	[Table("tbl_requisitionDetail")]
	public class RequisitionDetail
	{
		[Key]
		public int ID { get; set; }
		public bool Email_Internal { get; set; }
		public bool Email_External { get; set; }
		public bool Internet_Restriction { get; set; }
		public bool Internet_NoRestriction { get; set; }
		public int ReqFormID { get; set; }
		public int empID { get; set; }
	}
}
