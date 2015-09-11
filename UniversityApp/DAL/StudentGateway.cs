using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using UniversityApp.Model;

namespace UniversityApp.DAL
{
    public class StudentGateway
    {
        private string connectionString =
            WebConfigurationManager.ConnectionStrings["UniversityDBConnectionString"].ConnectionString;
        public int SaveStudent(Student student)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Students VALUES ('" + student.Name + "', '" + student.Email + "', '" + student.Phone + "', '" + student.RegNo + "', " + student.DepartmentID + ")";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }

        public List<Student> GetAllStudents()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Students";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<Student> students = new List<Student>();

            while (reader.Read())
            {
                Student student = new Student();
                student.StudentID = (int)reader["StudentID"];
                student.Name = reader["Name"].ToString();
                student.Email = reader["Email"].ToString();
                student.Phone = reader["Phone"].ToString();
                student.RegNo = reader["RegNo"].ToString();
                student.DepartmentID = (int)reader["DepartmentID"];

                students.Add(student);
            }

            reader.Close();
            connection.Close();

            return students;
        }

        public Student IsExist(Student student)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Students WHERE RegNo='" + student.RegNo + "'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Student aStudent = null;
            if (reader.HasRows)
            {
                reader.Read();
                aStudent = new Student();
                aStudent.StudentID = (int)reader["StudentID"];
                aStudent.Name = reader["Name"].ToString();
                aStudent.Email = reader["Email"].ToString();
                aStudent.Phone = reader["Phone"].ToString();
                aStudent.RegNo = reader["RegNo"].ToString();
            }
            reader.Close();
            connection.Close();

            return aStudent;
        }

        public bool UpdateStudent(Student student)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "UPDATE Students SET Name='" + student.Name + "', Email='" + student.Email + "', Phone='" + student.Phone + "' WHERE StudentID='" + student.StudentID + "'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            if (rowAffected > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteStudent(int studentId)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            string query = "DELETE FROM Students WHERE StudentID=" + studentId;

            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = connection;

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            if (rowAffected > 0)
            {
                return true;
            }

            return false;
        }

        public List<StudentWiseDepartmentView> GetStudentWiseDepartment()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT s.Name AS [Student Name], s.Email, s.RegNo, d.Code, d.Name AS [Department Name] FROM Students s JOIN Departments d ON s.DepartmentID = d.DepartmentID";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<StudentWiseDepartmentView> studentWiseDepartments = new List<StudentWiseDepartmentView>();

            while (reader.Read())
            {
                StudentWiseDepartmentView studentWiseDepartment = new StudentWiseDepartmentView();
                studentWiseDepartment.StudentName = reader["Student Name"].ToString();
                studentWiseDepartment.Email = reader["Email"].ToString();
                studentWiseDepartment.RegNo = reader["RegNo"].ToString();
                studentWiseDepartment.DeptCode = reader["Code"].ToString();
                studentWiseDepartment.DeptName = reader["Department Name"].ToString();

                studentWiseDepartments.Add(studentWiseDepartment);
            }

            reader.Close();
            connection.Close();

            return studentWiseDepartments;
        }
    }
}