using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet("/")]
		public IActionResult Index()
		{
			using (var adventureWorks = new AdventureWorksManager())
			{
				var viewmodel = new HomeViewModel();
				viewmodel.Departments = adventureWorks.GetDepartments();

				return View("Index", viewmodel);
			}
		}

		public IActionResult ViewDepartment(int id, string name)
		{
			using (var adventureWorks = new AdventureWorksManager())
			{
				var viewmodel = new DepartmentViewModel();
				viewmodel.DepartmentName = name;
				viewmodel.Employees = adventureWorks.GetEmployeesInDepartment(id);

				return View("ViewDepartment", viewmodel);
			}
		}

		public IActionResult ViewEmployee(int id)
		{
			using (var adventureWorks = new AdventureWorksManager())
			{
				var viewmodel = new EmployeeViewModel();

				viewmodel.Employee = adventureWorks.GetEmployeeByID(id);
				viewmodel.PayHistories = adventureWorks.GetEmployeePayHistory(id);
				viewmodel.DepartmentHistories = adventureWorks.GetEmployeeDepartmentHistory(id);

				return View("ViewEmployee", viewmodel);
			}
		}
	}
}
