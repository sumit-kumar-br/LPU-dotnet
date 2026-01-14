
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_Assignment_BoilerPlateCode.Repos;
using LINQ_Assignment_BoilerPlateCode.DTOs;
using LINQ_Assignment_BoilerPlateCode.Models;
using System.ComponentModel;

namespace LINQ_Assignment_BoilerPlateCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // =======================
            // SAMPLE DATA
            // =======================
            var employees = EmployeeRepo.SeedEmployees();
            var projects = ProjectRepo.SeedProjects();

            Console.WriteLine("LINQ Scenario Boilerplate Loaded");

            //var q1 = GetHighEarningEmployees(employees);
            //foreach (var item in q1)
            //{
            //    System.Console.WriteLine(item.Name);
            //}

            //var q2 = GetEmployeeNames(employees);
            //foreach (var item in q2)
            //{
            //    System.Console.WriteLine(item);
            //}

            var q9 = GetAllUniqueSkills(employees);
            foreach(var item in q9)
            {
                Console.WriteLine(item);
            }


        }

        // =====================================================
        // 🟢 SECTION 1 – HR ANALYTICS
        // =====================================================

        // TODO 1.1: Get employees earning more than 60,000
        static List<Employee> GetHighEarningEmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var query = employees.Where(s=>s.Salary>60000).ToList();
            return query;
        }

        // TODO 1.2: Get list of employee names only
        static List<string> GetEmployeeNames(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var query = employees.Select(s =>s.Name).ToList();
            return query;
        }

        // TODO 1.3: Check if any employee belongs to HR department
        static bool HasHREmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var query = employees.Any(s => s.Department == "HR");
            return query;
        }

        // =====================================================
        // 🟡 SECTION 2 – MANAGEMENT INSIGHTS
        // =====================================================

        // TODO 2.1: Get department-wise employee count
        static List<DepartmentCount> GetDepartmentWiseCount(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var query = employees
                        .GroupBy(s => s.Department)
                        .Select(x => new DepartmentCount{ Department = x.Key, Count = x.Count() })
                        .ToList();
            return query;
                        
        }

        // TODO 2.2: Find the highest paid employee
        static Employee GetHighestPaidEmployee(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var query = employees
                        .OrderByDescending(s => s.Salary)
                        .FirstOrDefault();
            return query;
        }

        // TODO 2.3: Sort employees by Salary (DESC), then Name (ASC)
        static List<Employee> SortEmployeesBySalaryAndName(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var query = employees
                        .OrderByDescending(s=>s.Salary)
                        .ThenBy(s=>s.Name)
                        .ToList();
            return query;
        }

        // =====================================================
        // 🔵 SECTION 3 – PROJECT & SKILL INTELLIGENCE
        // =====================================================

        // TODO 3.1: Join employees with projects
        static List<EmployeeProject> GetEmployeeProjectMappings(
            List<Employee> employees,
            List<Project> projects)
            {
                // TODO: Write LINQ query here
                var query = employees
                            .Join(projects,
                                    e=>e.Id,
                                    p => p.EmployeeId,
                                    (e, p)=>new EmployeeProject
                                    {EmployeeName = e.Name, ProjectName = p.ProjectName})
                            .ToList();
                return query;
            }

        // TODO 3.2: Find employees who are NOT assigned to any project
        static List<Employee> GetUnassignedEmployees(
            List<Employee> employees,
            List<Project> projects)
            {
            // TODO: Write LINQ query here
            var query = employees
                        .Where(e => !projects.Any(p => p.EmployeeId == e.Id))
                        .ToList();
            return query;
            }

        // TODO 3.3: Get all unique skills across the organization
        static List<string> GetAllUniqueSkills(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var query = employees.SelectMany(s=>s.Skills)
                                 .Distinct()
                                 .ToList();
            return query;
        }

        // =====================================================
        // 🔴 SECTION 4 – ADVANCED WORKFORCE ANALYTICS
        // =====================================================

        // TODO 4.1: Get top 3 highest-paid employees per department
        static List<DepartmentTopEmployees> GetTopEarnersByDepartment(
            List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var query = employees.GroupBy(s => s.Department)
                                 .Select(x => new DepartmentTopEmployees
                                 {
                                     Department = x.Key,
                                     TopEmployees = x.OrderByDescending(e => e.Salary)
                                                    .Take(3)
                                                    .ToList()
                                 }).ToList();
            return query;
        }

        // TODO 4.2: Remove duplicate employees based on Id
        static List<Employee> RemoveDuplicateEmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var query = employees.GroupBy(e=>e.Id)
                                 .Select(s=>s.First())
                                 .ToList();
            return query;
        }

        // TODO 4.3: Implement pagination
        static List<Employee> GetEmployeesByPage(
            List<Employee> employees,
            int pageNumber,
            int pageSize = 5)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }


    }
}
