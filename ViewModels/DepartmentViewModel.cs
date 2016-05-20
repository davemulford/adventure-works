using System;
using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.ViewModels
{
	public class DepartmentViewModel
	{
		public string DepartmentName { get; set; }
		public List<Employee> Employees { get; set; }
	}
}
