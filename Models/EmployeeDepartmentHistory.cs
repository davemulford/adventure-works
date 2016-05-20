using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
	[Table("employeedepartmenthistory")]
	public partial class EmployeeDepartmentHistory
	{
		[Column("businessentityid")]
		public int BusinessEntityID { get; set; }

		[Column("departmentid")]
		public int DepartmentID { get; set; }

		[Column("shiftid")]
		public int ShiftID { get; set; }

		[Column("startdate")]
		public DateTime StartDate { get; set; }

		[Column("enddate")]
		public DateTime? EndDate { get; set; }

		[Column("modifieddate")]
		public DateTime ModifiedDate { get; set; }

		[ForeignKey("DepartmentID")]
		public Department Department { get; set; }

		[ForeignKey("ShiftID")]
		public Shift Shift { get; set; }
	}
}
