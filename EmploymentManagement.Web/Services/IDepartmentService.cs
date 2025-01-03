﻿using EmployeeManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmploymentManagement.Web.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int id);
    }
}
