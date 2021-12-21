using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticketTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ticket Tester";
            Receptionist final = new Receptionist();
            final.ticketPrint();
        }
    }
}