using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticketTester
{
    class Process
    {
        string name = "";
        int age = 0;
        string result = "";
        public void retrieveData()
        {
            Console.Write("Enter first name: ");
            name = Console.ReadLine();
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
        }
        public void processData()
        {
            if (age < 18)
            {
                result = name + " X";
                Console.WriteLine(result);
                Console.WriteLine("----------------");
            }
            else if (age >= 18)
            {
                Console.Write("Enter last name: ");
                string lname = Console.ReadLine();
                Console.Write("Enter gender, M or F: ");
                string gender = Console.ReadLine();

                if (gender == "M")
                {
                    result = "Mr. " + lname + " is allowed into the program.";
                    Console.WriteLine(result);
                    Console.WriteLine("----------------");
                }
                else if (gender == "F")
                {
                    result = "Miss. " + lname + " is allowed into the program.";
                    Console.WriteLine(result);
                    Console.WriteLine("----------------");
                }
                else
                {
                    result = "Err: Incorrect format.";
                    Console.WriteLine(result);
                    Console.WriteLine("----------------");
                }
            }
        }
        public string returnResult()
        {
            retrieveData();
            processData();
            return result;
        }
    }
}
