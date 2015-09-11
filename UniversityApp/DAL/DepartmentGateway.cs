using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Configuration;
using UniversityApp.Model;

namespace UniversityApp.DAL
{
    public class DepartmentGateway
    {
        private string connectionString =
            WebConfigurationManager.ConnectionStrings["UniversityDBConnectionString"].ConnectionString;

        public List<Department> GetAllDepartments()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Departments";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Department> departments = new List<Department>();
            while (reader.Read())
            {
                Department department = new Department();
                department.DepartmentID = (int)reader["DepartmentID"];
                department.Code = reader["Code"].ToString();
                department.Name = reader["Name"].ToString();

                departments.Add(department);
            }
            reader.Close();
            connection.Close();

            return departments;
        }

        public Department GetDepartmentById(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Departments WHERE DepartmentID="+id;

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Department department = null;
            while (reader.Read())
            {
                department = new Department();
                department.DepartmentID = (int)reader["DepartmentID"];
                department.Code = reader["Code"].ToString();
                department.Name = reader["Name"].ToString();
            }
            reader.Close();
            connection.Close();

            return department;
        }
    }
}