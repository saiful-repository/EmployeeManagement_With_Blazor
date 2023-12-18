﻿using EmployeeManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmploymentManagement.Web.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
    }
}