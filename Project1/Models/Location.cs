using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
	public class Location
	{
		[Key]
		public int LocationID { get; set; } // 地區編號，主鍵

		[Display (Name = "地區")]
		public string LocationName { get; set; } // 地區名稱
	}
}
