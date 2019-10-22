/*Programmer: Ivoire Morrell
 *Program: Regex expression lab
 *Date: 10/21/2019 
 *Description: This program is a validation that tests to see 
 * if different user entered variables match the correct format
 */





using System;
using System.Text.RegularExpressions;

namespace RegularExpressionsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize variables
            string name;
            string email;
            string number;
            string date;
            string html;

            //Tell the user to enter a name
            Console.WriteLine("Please enter a name \n");

            name = Console.ReadLine();

            Console.WriteLine();

            //call the ValidName
            ValidName(name);

            Console.WriteLine();

            //ask the user to enter a email
            Console.WriteLine("Please enter a email \n");

            email = Console.ReadLine();

            Console.WriteLine();

            //pass the email strin to the Valid email method
            ValidEmail(email);

            Console.WriteLine();

            //Ask the user for a phone number
            Console.WriteLine("Please enter a 10 digit phone number \n");

            number = Console.ReadLine();

            Console.WriteLine();

            //pass number to ValidNumber method
            ValidNumber(number);

            Console.WriteLine();

            //Ask the user to enter a date
            Console.WriteLine("Please enter a date (use DD/MM/YYYY format) \n");

            date = Console.ReadLine();

            Console.WriteLine();

            //pass date to the ValidDate method
            ValidDate(date);

            Console.WriteLine();

            //Ask the user to enter a HTML tag
            Console.WriteLine("Enter HTML tag \n");

            html = Console.ReadLine();

            Console.WriteLine();

            //pass variable to HTML method
            ValidHTML(html);

            Console.WriteLine();
        }

        //This method validates user names. The name should start with a captal letter, be all alphabet, and be no loner then 30 characters
        public static void ValidName(string name)
        {

            //use if statement to validate the expression
            if (Regex.IsMatch(name, "[A-Z][a-z]{1,30}"))
            {
                Console.WriteLine("This name is valid");
            }
            else
            {
                Console.WriteLine("Sorry, name is invalid");
            }

        }

        //The ValidEmail method checks to see if the user entered email is valid or invalid
        public static void ValidEmail(string email)
        {
            //validate email
            if (Regex.IsMatch(email, "[a-zA-Z0-9]{5,30}@[a-zA-Z0-9]{5,10}.[a-zA-Z0-9]{2,3}"))
            {
                //user entered valid email
                Console.WriteLine("Valid email");
            }
            else
            {
                //invalid email
                Console.WriteLine("Sorry, email is invalid");

            }
        }

        // the ValidNumber method checks to see if the user 
        //entered a valid number that follows the 3/3/4 format
        public static void ValidNumber(string number)
        {
            //check to see if user entered valid number
            if (Regex.IsMatch(number, @"\d{3}-\d{3}-\d{4}"))
            {
                //the number is valid
                Console.WriteLine("Number is valid");
            }
            else
            {
                //number is invalid
                Console.WriteLine("Sorry, number is invalid");
            }

        }

        //The ValidDate method checks to see if the user entered a valid date
        public static void ValidDate(string date)
        {
            //check to see if date is valid
            if (Regex.IsMatch(date, "(([0-2][0-9])|([1-9])|(3[0-1]))/(((0)[0-9])|((1)[0-2]))/[0-9]{4}"))
            {
                //Date is valid
                Console.WriteLine("Date is valid");
            }
            else
            {
                //Date is invalid
                Console.WriteLine("Sorry, date is invalid");
            }
        }

        //This method checks to see if the element entered by the user is valid HTML
        public static void ValidHTML(string html)
        {
            //check to see if the user entered a valid html tag
            if (Regex.IsMatch(html, "<[^>]*>"))
            {
                //valid html
                Console.WriteLine("Valid HTML");
            }
            else
            {
                //invalid HTML
                Console.WriteLine("Sorry, this is not valid HTML");
            }
        }
    }
}
