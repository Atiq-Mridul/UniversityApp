namespace UniversityApp.Model
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string RegNo { get; set; }
        public string Address { get; set; }
        public int DepartmentID { get; set; }

        public Student(string name, string email, string phone, string regNo, int departmentID)
        {
            Name = name;
            Email = email;
            Phone = phone;
            RegNo = regNo;
            DepartmentID = departmentID;
        }

        public Student()
        {
            
        }
    }
}