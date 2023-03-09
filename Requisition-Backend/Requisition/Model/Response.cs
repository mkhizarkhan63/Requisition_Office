using System.Collections;
using System.Collections.Generic;

namespace Requisition.Model
{
	public class Response
	{

		public IEnumerable<dynamic> dataList { get; set; }
		public dynamic data { get; set; }
		public bool  flag { get; set; }
		public int status { get; set; }
		public string message { get; set; }
	}
}
