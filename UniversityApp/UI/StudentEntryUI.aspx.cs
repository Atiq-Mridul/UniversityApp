using System;
using System.Data.SqlClient;
using UniversityApp.BLL;
using UniversityApp.Model;

namespace UniversityApp.UI
{
    public partial class StudentEntryUI : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();
        DepartmentManager departmentManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                departmentDropDownList.DataTextField = "Code";
                departmentDropDownList.DataValueField = "DepartmentID";
                departmentDropDownList.DataSource = departmentManager.GetAllDepartments();
                departmentDropDownList.DataBind();
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneNoTextBox.Text;
            string regNo = regNoTextBox.Text;
            int departmentID = Convert.ToInt32(departmentDropDownList.SelectedValue);
            Student student = new Student(name, email, phone, regNo, departmentID);

            messageLabel.Text = studentManager.SaveStudent(student);
        }

        protected void departmentDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int departmentID = Convert.ToInt32(departmentDropDownList.SelectedValue);
            Department department = departmentManager.GetDepartmentById(departmentID);

            departmentNameLabel.Text = department.Name;
        }
    }
}