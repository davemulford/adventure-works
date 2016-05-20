using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
	[Table("shift")]
	public class Shift
	{
		[Key]
		[Column("shiftid")]
		public int ShiftID { get; set; }

		[Column("name")]
		public string Name { get; set; }

		[Column("starttime")]
		public TimeSpan StartTime { get; set; }

		[Column("endtime")]
		public TimeSpan EndTime { get; set; }

		[Column("modifieddate")]
		public DateTime ModifiedDate { get; set; }
	}
}
