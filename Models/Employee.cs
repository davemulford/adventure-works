using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
	[Table("employee")]
	public class Employee
	{
		[Key]
		[Column("businessentityid")]
		public int BusinessEntityID { get; set; }

		[Column("nationalidnumber")]
		public string NationalIDNumber { get; set; }

		[Column("loginid")]
		public string LoginID { get; set; }

		[Column("jobtitle")]
		public string JobTitle { get; set; }

		[Column("birthdate")]
		public DateTime BirthDate { get; set; }

		[Column("maritalstatus")]
		public string MaritalStatus { get; set; }

		[Column("gender")]
		public string Gender { get; set; }

		[Column("hiredate")]
		public DateTime HireDate { get; set; }

		[Column("salariedflag")]
		public bool SalariedFlag { get; set; }

		[Column("vacationhours")]
		public int VacationHours { get; set; }

		[Column("sickleavehours")]
		public int SickLeaveHours { get; set; }

		[Column("currentflag")]
		public bool CurrentFlag { get; set; }

		[Column("rowguid")]
		public Guid RowGuid { get; set; }

		[Column("modifieddate")]
		public DateTime ModifiedDate { get; set; }
	}
}
