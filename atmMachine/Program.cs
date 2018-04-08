using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace atmMachine
{
    class Program
    {
        static void Main(String[] args)
        {
            Account acc = new Account("John", 5000);
            acc.showAccountInfo();

            System.Console.ReadKey();

        }
    }
}