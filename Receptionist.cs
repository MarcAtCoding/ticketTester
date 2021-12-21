using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticketTester
{
    class Receptionist
    {
        public void ticketPrint()
        {
            Process procObj = new Process();
            Console.Write("How many applicants there are: ");
            int app = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < app; i++)
            {
                procObj.returnResult();
            }
        }
    }
}
