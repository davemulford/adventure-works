using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
	[Table("employeedepartmenthistory")]
	public class EmployeeDepartmentHistory
	{
		[Column("businessentityid")]
		public int BusinessEntityID { get; set; }

		[Column("departmentid")]
		public int DepartmentID { get; set; }

		[Column("shift")]
		public int Shift { get; set; }

		[Column("startdate")]
		public DateTime StartDate { get; set; }

		[Column("enddate")]
		public DateTime EndDate { get; set; }
	}
}
