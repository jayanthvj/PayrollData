using System;

namespace PayrollSystem
{
    public class Data
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Id { get; set; }
        public string EmailID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long Mobilenumber { get; set; }
        public string DepartmentName { get; set; }
        public double Salary { get; set; }
        public Data() { }
        public Data(string Name, int Id, string Designation, string EmailID, DateTime DateOfBirth, long Mobilenumber, string DepartmentName, double Salary)
        {
            this.Name = Name;
            this.Id = Id;
            this.EmailID = EmailID;
            this.Designation = Designation;
            this.DateOfBirth = DateOfBirth;
            this.Mobilenumber = Mobilenumber;
            this.DepartmentName = DepartmentName;
            this.Salary = Salary;
        }
        public override string ToString()
        {
            return "Employee Name:" + Name + "Employee ID :" + Id + " Employee Email :" + EmailID + "Employee Designation :" + Designation + " Employee DOB :" + DateOfBirth + "Employee Mobile Number " + Mobilenumber + "Employee Salary " + Salary;
        }
    }
  

}
