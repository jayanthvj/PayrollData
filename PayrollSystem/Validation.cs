﻿using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace PayrollSystem
{

    public class RegistrationValidation
    {
        public string UserName, EmployeeName, Email, Password, ConfirmPassword, RegistrationNumber;
        public long MobileNumber;
        public DateTime DateOfBirth;
        public int PinCode, ID;
        //public void AddUser()
        //{
        //    name = validateName();
        //    mobile = ValidateCellNumber();
        //    dob = validateDob();
        //    mail = validateMail();
        //    password = validatePassword();
        //    registration();
        //}
        //validate name is done here...

        internal string ValidName()
        {
            Console.WriteLine("FirstName : ");
            EmployeeName = Console.ReadLine();

            if (EmployeeName.Length < 2 && EmployeeName.Length > 20)
            {
                Console.WriteLine("The name is not valid try again..");
                EmployeeName = ValidName();
            }
            Regex check = new Regex(@"^([A-Z][a-z-A-Z])$");
            bool valid = check.IsMatch(EmployeeName);
            //Regex check1 = new Regex(@"^([0-9])$");
            if (check.IsMatch(EmployeeName) == true)
            {
                valid = false;
            }
            char[] charName = EmployeeName.ToCharArray();
            for (int i = 0; i < charName.Length - 2; i++)
            {
                if ((charName[i] == charName[i + 1]) && (charName[i + 1] == charName[i + 2]))
                {
                    valid = false;
                    break;
                }
            }
            if ((valid != false))
            {
                Console.WriteLine("Name is Invalid..");
                EmployeeName = ValidName();
            }
            return EmployeeName;
        }

       internal long ValidateMobileNumber()
        {
            Console.WriteLine("Mobile Number : ");
            try
            {
                MobileNumber = Convert.ToInt64(Console.ReadLine());
            }
            catch (MyException myexception)
            {
                Console.WriteLine(myexception.Message == "Invalid MobileNumber..");
                FileLogger.Writing(myexception.Message);
                ValidateMobileNumber();
            }
            Regex check = new Regex(@"^[0-9]");
            bool valid = check.IsMatch(MobileNumber.ToString());
            if ((MobileNumber.ToString().Length == 10) && (valid == true) && MobileNumber > 6000000000 && MobileNumber < 9999999999)
            {
                return MobileNumber;
            }
            else
            {
                Console.WriteLine("Cell Number is Invalid..");
                ValidateMobileNumber();
            }
            return MobileNumber;
        }

        internal DateTime ValidateDateOfBirth()
        {
            Console.WriteLine("Date Of Birth : ");
            try
            {
                DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            }
            catch (MyException exception)
            {
                Console.WriteLine(exception.Message == "Invalid Date of birth..");
                FileLogger.Writing(exception.Message);
                ValidateDateOfBirth();
            }
            DateTime dateTime = DateTime.Today;
            int age = dateTime.Year - DateOfBirth.Year;
            if (age < 18 || age > 80)
            {
                Console.WriteLine("Invalid Date of birth..");
                ValidateDateOfBirth();
            }
            return DateOfBirth;
        }
        internal string ValidateMail()
        {
            Console.WriteLine("E-mail : ");
            Email = Console.ReadLine();
            try
            {
                MailAddress mailid = new MailAddress(Email);
                return Email;
            }
            catch (MyException exception)
            {
                Console.WriteLine(exception.Message == "Invalid Mail Id");
                FileLogger.Writing(exception.Message);
                ValidateMail();
            }
            return Email;
        }

        //internal string GenereteUserName()
        //{
        //    Random random = new Random();
        //    UserName = EmployeeName + random.Next(10);
        //    Console.WriteLine("User Name : " + UserName);
        //    return UserName;
        //}
        //     internal string GeneratePassword()
        //{
        //    Random random = new Random();
        //    Password = "Aspire" + random.Next(1000);
        //    Console.WriteLine("Password " + Password);
        //    return Password;
        //}
    }
    
}