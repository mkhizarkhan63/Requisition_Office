using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Requisition.Model
{
	[Table("tbl_user")]
	public class User
	{
		[Key]
		[JsonIgnore]
		public int ID { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }

	}
}
