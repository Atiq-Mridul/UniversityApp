using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityApp.DAL;
using UniversityApp.Model;

namespace UniversityApp.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway departmentGateway = new DepartmentGateway();

        public List<Department> GetAllDepartments()
        {
            return departmentGateway.GetAllDepartments();
        }

        public Department GetDepartmentById(int id)
        {
            return departmentGateway.GetDepartmentById(id);
        }
    }
}