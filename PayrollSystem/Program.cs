using System;
using System.Collections.Generic;

namespace PayrollSystem
{

    class Admin
    {
        List<Admin> data = new List<Admin>();
        private static string adminName, employeeName, adminPassword, employeePassword;
        static Admin()
        {
            adminName = "JayanthAspire";
            adminPassword = "Jayanth@123";
            employeeName = "ilangoAspire";
            employeePassword = "ilango@123";
        }
        public void AdminLogin()
        {
            Admin home = new Admin();
            Console.WriteLine("Enter the User name");
            string admin = Console.ReadLine();
            Console.WriteLine("Enter the password");
            string adminspassword = Console.ReadLine();
            if (admin.Equals(adminName) && adminspassword.Equals(adminPassword))
            {
                Console.WriteLine("You have login as Admin ");
                home.ToControl();
            }
            else
            {
                Console.WriteLine("Login failed");
            }
        }

        public void EmployeeLogin()
        {
            Admin home = new Admin();
            Console.WriteLine("Enter the  User name");
            employeeName = Console.ReadLine();
            Console.WriteLine("Enter the Password");
            employeePassword = Console.ReadLine();
            if (employeeName.Equals(employeeName) && employeePassword.Equals(employeePassword))
            {
                Console.WriteLine("You have login as Employee ");
                home.EmployeeControl();
            }
            else
            {
                Console.WriteLine("Login failed");
            }

        }
      

        public void Management()                 
        {
            start:
            try
            {
                Admin management = new Admin();
                Console.WriteLine("*********************Welcome to Login*************************");
                Console.WriteLine("Enter your choice\n1.Admin\n2.Employee\n3.Exit");
                int option = int.Parse(Console.ReadLine());
                do
                {
                    switch (option)
                    {
                        case 1:
                            management.AdminLogin();
                            break;
                        case 2:
                            management.EmployeeLogin();
                            break;
                        case 3:
                            Management();
                            break;
                    }
                    Console.WriteLine("*********************Welcome to Login*************************");
                    Console.WriteLine("Enter your choice\n1.Admin\n2.Employee\n3.Main");
                    option = int.Parse(Console.ReadLine());
                } while (option != 2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                FileLogger.Writing(e.Message);
                goto start;
            }
        }
        public void EmployeeControl()
        {
            start:
            try
            {
                EmployeeDataInsertion employeeDatacollection = new EmployeeDataInsertion();
                Console.WriteLine("*********************Welcome to employee page*************************");
                Console.WriteLine("Enter your choice\n1.View Details\n2.Main");
                int option = int.Parse(Console.ReadLine());
                do
                {
                    switch (option)
                    {
                        case 1:
                            employeeDatacollection.DisplayEmployee();
                            break;
                        case 2:
                            Management();
                            break;
                    }
                    Console.WriteLine("*********************Welcome to employee page*************************");
                    Console.WriteLine("Enter your choice\n1.View Details\n2.Main");
                    option = int.Parse(Console.ReadLine());
                } while (option != 6);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                FileLogger.Writing(e.Message);
                goto start;
            }
        }
        public void ToControl()                   
        {
            start:
            try
            {
                EmployeeDataInsertion employeeCollection = new EmployeeDataInsertion();
                Console.WriteLine("*********************Welcome to Admin Page*************************");
                Console.WriteLine("Enter your choice\n1.EmployeeData\n2.DisplayData\n3.Main");
                int select = int.Parse(Console.ReadLine());
                do
                {
                    switch (select)
                    {
                        case 1:
                            employeeCollection.AddEmployees();
                            break;
                        case 2:
                            employeeCollection.DisplayEmployee();
                            break;
                       
                        case 3:
                            Management();
                            break;
                          
                    }
                    Console.WriteLine("*********************Thank you*************************");
                    Console.WriteLine("");
                    Console.WriteLine("Enter your choice\n1.EmployeeData\n2.DisplayData\n3.Main");
                    select = int.Parse(Console.ReadLine());
                } while (select != 6);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                FileLogger.Writing(e.Message);
                goto start;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Admin user = new Admin();
                user.Management();
              
            }
        }
    }
}

