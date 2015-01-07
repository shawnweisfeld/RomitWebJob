using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomitWebJob
{
    // To learn more about Microsoft Azure WebJobs, please see http://go.microsoft.com/fwlink/?LinkID=401557
    class Program
    {
        static void Main()
        {
            JobHost host = new JobHost();
            host.RunAndBlock();
        }

        private static void Initialize()
        {
            Console.WriteLine("Initialize Start.");


            Console.WriteLine("Initialize Finish.");
        }


    }
}
