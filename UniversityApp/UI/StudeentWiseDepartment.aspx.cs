﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityApp.BLL;

namespace UniversityApp.UI
{
    public partial class StudeentWiseDepartment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        StudentManager studentManager = new StudentManager();
        protected void showButton_Click(object sender, EventArgs e)
        {
            studentWiseDepartmentGridView.DataSource = studentManager.GetStudentWiseDepartment();
            studentWiseDepartmentGridView.DataBind();
        }
    }
}