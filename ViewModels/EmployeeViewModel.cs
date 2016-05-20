using System;
using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.ViewModels
{
	public class EmployeeViewModel
	{
		public Employee Employee { get; set; }
		public List<EmployeePayHistory> PayHistories { get; set; }
		public List<EmployeeDepartmentHistory> DepartmentHistories { get; set; }
	}
}
