using System;

namespace EducationAutomationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("You need to specify the authorization you want to log in.");
            Console.Write("Please enter '1' to log in as a student or enter '2' to log in as an instructor: ");
            
            int choice = Console.Read();
            switch (choice)
            {
                case '1':
                    Instructor ınstructor = new Instructor();
                    
                    Console.Write("Enter the password shared with you for instructors to continue: ");
                    string temp = Console.ReadLine().Trim();
                    Boolean flag = ınstructor.PasswordController(temp, choice);
                    while ( !flag )
                    {
                        Console.WriteLine("Password incorrect, please try again: ");
                        flag = ınstructor.PasswordController(Console.ReadLine().Trim(), choice);
                    }

                    Console.WriteLine("Please enter your first name (At least 3 characters) : ");
                    temp = Console.ReadLine().Trim();
                    flag = ınstructor.NameLenghtController(temp);
                    while ( !flag ) 
                    {
                        Console.WriteLine("At least 3 characters are required. Please try again: ");
                        temp = Console.ReadLine().Trim();
                        flag = ınstructor.NameLenghtController(temp);
                    }
                    ınstructor.FirstName = temp;

                    Console.WriteLine("Please enter your second name (Blank is valid) : ");
                    ınstructor.SecondName = Console.ReadLine().Trim();

                    Console.WriteLine("Please enter your last name (At least 3 characters) : ");
                    temp = Console.ReadLine().Trim();
                    flag = ınstructor.NameLenghtController(temp);
                    while ( !flag )
                    {
                        Console.WriteLine("At least 3 characters are required. Please try again: ");
                        temp = Console.ReadLine().Trim();
                        flag = ınstructor.NameLenghtController(temp);
                    }
                    ınstructor.LastName = temp;
                    break;
                case '2':
                    Student student = new Student();

                    Console.WriteLine("Enter the password shared with you for student to continue: ");
                    temp = Console.ReadLine().Trim();
                    flag = student.PasswordController(temp, choice);
                    while ( !flag )
                    {
                        Console.WriteLine("Password incorrect, please try again: ");
                        flag = student.PasswordController(Console.ReadLine().Trim(), choice);
                    }

                    Console.WriteLine("Please enter your first name (At least 3 characters) : ");
                    temp = Console.ReadLine().Trim();
                    flag = student.NameLenghtController(temp);
                    while (!flag)
                    {
                        Console.WriteLine("You have entered incorrectly. At least 3 characters are required.");
                        Console.WriteLine("Please enter your first name (At least 3 characters) : ");
                        temp = Console.ReadLine().Trim();
                        flag = student.NameLenghtController(temp);
                    }
                    student.FirstName = temp;

                    Console.WriteLine("Please enter your second name (Blank is valid) : ");
                    student.SecondName = Console.ReadLine().Trim();

                    Console.WriteLine("Please enter your last name (At least 3 characters) : ");
                    temp = Console.ReadLine().Trim();
                    flag = student.NameLenghtController(temp);
                    while (!flag)
                    {
                        Console.WriteLine("You have entered incorrectly. At least 3 characters are required.");
                        Console.WriteLine("Please enter your last name (At least 3 characters) : ");
                        temp = Console.ReadLine().Trim();
                        flag = student.NameLenghtController(temp);
                    }
                    student.LastName = temp;
                    break;
                default:
                    Console.WriteLine(String.Format("Unknown command: {0}", choice.ToString()));
                    break;
            }
            Console.ReadKey();
        }
    }
}
