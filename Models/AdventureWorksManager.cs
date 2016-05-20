using System;
using System.Linq;
using System.Collections.Generic;

namespace WebApp.Models
{
	public class AdventureWorksManager : IDisposable
	{
		private AdventureWorksDbContext adventureWorksDB;

		public AdventureWorksManager()
		{
			adventureWorksDB = new AdventureWorksDbContext();
		}

		public void Dispose()
		{
			if (adventureWorksDB != null)
			{
				adventureWorksDB.Dispose();
			}
		}

		public List<Department> GetDepartments()
		{
			try
			{
				return adventureWorksDB.Departments.ToList();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				return new List<Department>();
			}
		}

		public List<Employee> GetEmployeesInDepartment(int departmentId)
		{
			try
			{
				return adventureWorksDB.EmployeeDepartmentHistories
					.Where(h => h.DepartmentID == departmentId)
					.Where(h => h.EndDate == null)
					.Join(adventureWorksDB.Employees,
						h => h.BusinessEntityID,
						e => e.BusinessEntityID,
						(h, e) => new Employee {
							BusinessEntityID = e.BusinessEntityID,
							LoginID = e.LoginID,
							HireDate = e.HireDate,
							JobTitle = e.JobTitle
						}
					).ToList();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				return new List<Employee>();
			}
		}

		public Employee GetEmployeeByID(int employeeId)
		{
			try
			{
				return adventureWorksDB.Employees.FirstOrDefault(e => e.BusinessEntityID == employeeId);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				return null;
			}
		}
	}
}
