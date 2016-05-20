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

		public List<EmployeePayHistory> GetEmployeePayHistory(int employeeId)
		{
			try
			{
				return adventureWorksDB.EmployeePayHistories
					.Where(h => h.BusinessEntityID == employeeId)
					.OrderByDescending(h => h.RateChangeDate)
					.ToList();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				return new List<EmployeePayHistory>();
			}
		}

		public List<EmployeeDepartmentHistory> GetEmployeeDepartmentHistory(int employeeId)
		{
			try
			{
				return adventureWorksDB.EmployeeDepartmentHistories
					.Where(h => h.BusinessEntityID == employeeId)
					.Join(adventureWorksDB.Departments, h => h.DepartmentID, d => d.DepartmentID, (h, d) => new { h, d })
					.Join(adventureWorksDB.Shifts, h => h.h.ShiftID, s => s.ShiftID, (h, s) => new { h.h, h.d, s })
					.Select(x => new EmployeeDepartmentHistory {
						BusinessEntityID = x.h.BusinessEntityID,
						DepartmentID = x.h.DepartmentID,
						ShiftID = x.h.ShiftID,
						StartDate = x.h.StartDate,
						EndDate = x.h.EndDate,
						ModifiedDate = x.h.ModifiedDate,
						Department = (x.d != null)
							? new Department {
								DepartmentID = x.d.DepartmentID,
								Name = x.d.Name,
								GroupName = x.d.GroupName,
								ModifiedDate = x.d.ModifiedDate
							}
							: (Department)null,

						Shift = (x.s != null)
							? new Shift {
								ShiftID = x.s.ShiftID,
								Name = x.s.Name,
								StartTime = x.s.StartTime,
								EndTime = x.s.EndTime,
								ModifiedDate = x.s.ModifiedDate
							}
							: (Shift)null
					})
					.OrderByDescending(h => h.StartDate)
					.ToList();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				return new List<EmployeeDepartmentHistory>();
			}
		}
	}
}
