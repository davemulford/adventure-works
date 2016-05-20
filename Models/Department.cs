using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
	[Table("department")]
	public class Department
	{
		[Key]
		[Column("departmentid")]
		public int DepartmentID { get; set; }

		[Column("name")]
		public string Name { get; set; }

		[Column("groupname")]
		public string GroupName { get; set; }

		[Column("modifieddate")]
		public DateTime ModifiedDate { get; set; }
	}
}
