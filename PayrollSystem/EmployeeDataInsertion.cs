using System;
using System.Collections.Generic;

namespace PayrollSystem
{
    class EmployeeDataInsertion : RegistrationValidation
    {
       List<Data> employeeinformation = new List<Data>();
       
       
        public bool AddEmployee(Data employee)
        {
            if (employeeinformation.Contains(employee))
                throw new MyException("This Data is Present Already");
            employeeinformation.Add(employee);
            return true;
        }
        public  void AddEmployees()
        {

            EmployeeName = ValidName();
            Console.WriteLine("Enter an Employee ID");
            int Id = int.Parse(Console.ReadLine());
            Email = ValidateMail();
            Console.WriteLine("Enter an Employee Designation");
            String Designation = Console.ReadLine();
            DateOfBirth = ValidateDateOfBirth();
            MobileNumber = ValidateMobileNumber();
            Console.WriteLine("Enter an Employee Designation");
            string DepartmentName = Console.ReadLine();
            Console.WriteLine("Enter an Employee Salary");
            Double Salary = double.Parse(Console.ReadLine());
            Data employee = new Data(EmployeeName, Id, Email, Designation, DateOfBirth, MobileNumber, DepartmentName, Salary);
            bool status = AddEmployee(employee);
            if (status)
            {
                Console.WriteLine("Details Added Successfully");

            }
        }

        public void DisplayEmployee()
        {
            foreach (var employeeinfo in employeeinformation)
            {
                Console.WriteLine(employeeinfo.ToString());
            }
        }
    }
}
