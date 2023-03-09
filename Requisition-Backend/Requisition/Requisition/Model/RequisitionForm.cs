using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Requisition.Model
{
	[Table("tbl_requisitionForm")]
	public class RequisitionForm
	{
		[Key]
		public int ID { get; set; }
		public bool WindowsDomainAccount { get; set; }
		public bool EmailAddress { get; set; }
		public bool InternetAccess { get; set; }
		public bool As400 { get; set; }
		public bool HIS { get; set; }
		public bool EMR { get; set; }
		public bool Oracle_ebs { get; set; }
		public bool AnyOther { get; set; }
		public string Remarks { get; set; }
		public DateTime CreatedDate { get; set; }

	}
}
