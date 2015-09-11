using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityApp.BLL;
using UniversityApp.Model;

namespace UniversityApp.UI
{
    public partial class DeleteStudentUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        StudentManager studentManager = new StudentManager();
        protected void deleteButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.RegNo = regNoTextBox.Text;

            messageLabel.Text = studentManager.DeleteStudent(student);
        }
    }
}