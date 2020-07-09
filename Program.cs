using System;
using System.Text.RegularExpressions;

namespace Lab_2._3_Validating_Input_With_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please enter a valid name:");
            string entryName = Console.ReadLine();
            Regex nameRegex = new Regex(@"^[A-Z][a-z][^0-9]{1,30}$");
            bool name = nameRegex.IsMatch(entryName);
            //Console.WriteLine(name);

            if (name == false)
                Console.WriteLine($"Sorry, name is not valid");
            else if (name == true)
                Console.WriteLine();

            Console.WriteLine($"Please enter a valid email:");
            string entryEmail = Console.ReadLine();
            Regex emailRegex = new Regex(@"^\w{5,30}@\w{5,10}.\w{2,3}$");
            bool email = emailRegex.IsMatch(entryEmail);
            //Console.WriteLine(email);

            if (email == false)
                Console.WriteLine($"Email is not valid");
            else if (email == true)
                Console.WriteLine($"Email is valid!\n");

            Console.WriteLine($"Please enter a valid phone number:");
            string entryPhone = Console.ReadLine();
            Regex phoneRegex = new Regex(@"^[0-9]{3}[.\s\-][0-9]{3}[.\s\-][0-9]{4}$");
            bool phone = phoneRegex.IsMatch(entryPhone);
            //Console.WriteLine(phone);

            if (phone == false)
                Console.WriteLine($"Sorry, phone is not valid!");
            else if (name == true)
                Console.WriteLine();

            Console.WriteLine($"Please enter a valid date:  dd/mm/yyyy");
            string entryDate = Console.ReadLine();
            Regex dateRegex = new Regex(@"^([0]?[1-9]|[1|2][0-9]|[3][0|1])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$");
            bool date = dateRegex.IsMatch(entryDate);
            //Console.WriteLine(date);

            if (date == false)
                Console.WriteLine($"Sorry, date is not valid!");
            else if (date == true)
                Console.WriteLine();

        }
    }
}
