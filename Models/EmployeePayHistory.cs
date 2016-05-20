using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
	[Table("employeepayhistory")]
	public class EmployeePayHistory
	{
		[Column("businessentityid")]
		public int BusinessEntityID { get; set; }

		[Column("ratechangedate")]
		public DateTime RateChangeDate { get; set; }

		[Column("rate")]
		public decimal Rate { get; set; }

		[Column("payfrequency")]
		public int PayFrequency { get; set; }

		[Column("modifieddate")]
		public DateTime ModifiedDate { get; set; }
	}
}
