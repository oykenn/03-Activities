using System;
using System.IO;

namespace enrollmentApp
{
    class enrollmentProgram
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello student, please fill up the enrollment form.");
            Console.WriteLine("------------------------------------------------------------------------------");

                    // fillin up student information
            Console.Write("First name: ");
            String fname = Console.ReadLine();
            Console.Write("Middle name: ");
            String mname = Console.ReadLine();
            Console.Write("Last name: ");
            String lastname = Console.ReadLine();

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine($"Welcome! {fname}, {mname} {lastname}. Choose your selected course.");
            Console.WriteLine();
            Console.WriteLine("Available Courses: Computer Science, Tourism Management, Computer Engineering");
            Console.Write("Press 1 for CS, 2 for TM, and 3 for CE: ");

                    // course selection by prompting 1 ,2 or 3
            int choiceCourse = int.Parse(Console.ReadLine());
            while (choiceCourse < 1 || choiceCourse > 3)
            {
                Console.WriteLine("Invalid selection. Please try again.");
                Console.Write("Press 1 for CS, 2 for TM, and 3 for CE: ");
                choiceCourse = int.Parse(Console.ReadLine());
            }
                    // path and required files for enrollment
            string directorPath = @"C:\Users\Kenn\Desktop\pdfs";
            string[] filesRequired = {
                "diploma-sample.pdf",
                "goodmoral-sample.pdf",
                "card-sample.pdf"
            };
                     // Choosing course using switch-case
            switch (choiceCourse)
            {
                case 1:
                              // Computer Science students enrollment process
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine($"Welcome future Scientist {fname}!");
                    Console.WriteLine("These are your requirements: ");
                    Console.WriteLine("Tuition Fee: 29,345.00");
                    Console.WriteLine("Senior HighSchool Diploma, Good Moral, SHS Report Card ");
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.Write("To proceed please type \"P\" if not please type \"C\" to cancel: ");
                    String PCChoose = Console.ReadLine();
                    if (string.Equals(PCChoose, "P", StringComparison.OrdinalIgnoreCase))
                    {       
                             // Checking if all requirements are met
                        if (CheckRequirements(directorPath, filesRequired))
                        {   
                            Console.WriteLine("------------------------------------------------------------------------------");
                            Console.Write("Enter amount (exact amount only): ");
                            double tFee = 29345.00;
                            double CSPay = double.Parse(Console.ReadLine());
                            if (CSPay == tFee)
                            {  
                                 Console.WriteLine("------------------------------------------------------------------------------");
                                Console.WriteLine($"Congratulations! {fname} {mname} {lastname}, you are officially enrolled!");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect amount. Please try again.");
                            }
                        }
                    }
                    else if (string.Equals(PCChoose, "C", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Operation canceled. Thank you for using the system.");
                    }
                    break;

                case 2:
                              // Tourism students enrollment process
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine($"Welcome future Tourism {fname}!");
                    Console.WriteLine("These are your requirements: ");
                    Console.WriteLine("Tuition Fee: 25,345.00");
                    Console.WriteLine("Senior HighSchool Diploma, Good Moral, SHS Report Card ");
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.Write("To proceed please type \"P\" if not please type \"C\" to cancel: ");
                    String TMChoose = Console.ReadLine();
                    if (string.Equals(TMChoose, "P", StringComparison.OrdinalIgnoreCase))
                    {
                        if (CheckRequirements(directorPath, filesRequired))
                        {   Console.WriteLine("------------------------------------------------------------------------------");
                            Console.Write("Enter amount (exact amount only): ");
                            double tFee = 25345.00;
                            double TMPay = double.Parse(Console.ReadLine());
                            if (TMPay == tFee)
                            {   
                                Console.WriteLine("------------------------------------------------------------------------------");
                                Console.WriteLine($"Congratulations! {fname} {mname} {lastname}, you are officially enrolled!");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect amount. Please try again.");
                            }
                        }
                    }
                    else if (string.Equals(TMChoose, "C", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Operation canceled. Thank you for using the system.");
                    }
                    break;

                case 3:
                                  // Computer Engrs students enrollment process
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine($"Welcome future Engineer {fname}!");
                    Console.WriteLine("These are your requirements: ");
                    Console.WriteLine("Tuition Fee: 30,345.00");
                    Console.WriteLine("Senior HighSchool Diploma, Good Moral, SHS Report Card ");
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.Write("To proceed please type \"P\" if not please type \"C\" to cancel: ");
                    String CEChoose = Console.ReadLine();
                    if (string.Equals(CEChoose, "P", StringComparison.OrdinalIgnoreCase))
                    {
                        if (CheckRequirements(directorPath, filesRequired))
                        {   Console.WriteLine("------------------------------------------------------------------------------");
                            Console.Write("Enter amount (exact amount only): ");
                            double tFee = 30345.00;
                            double CEPay = double.Parse(Console.ReadLine());
                            if (CEPay == tFee)
                            {   
                                Console.WriteLine("------------------------------------------------------------------------------");
                                Console.WriteLine($"Congratulations! {fname} {mname} {lastname}, you are officially enrolled!");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect amount. Please try again.");
                            }
                        }
                    }
                    else if (string.Equals(CEChoose, "C", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Operation canceled. Thank you for using the system.");
                    }
                    break;
            }
        }

        static bool CheckRequirements(string directoryPath, string[] filesRequired)
        {
            bool allFilesFound = true;
            foreach (string fileName in filesRequired)
            {
                string filePath = Path.Combine(directoryPath, fileName);
                if (File.Exists(filePath))
                {
                    Console.WriteLine($"Your file {fileName} exist. ");
                }
                else
                {
                    Console.WriteLine($"Your file {fileName} not found!");
                    allFilesFound = false;
                }
            }
            return allFilesFound;
        }
    }
}
