using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            process.ProcessCompleted += b1ProcessCompleted;
            process.StartProcess();

            Console.ReadLine();
        }

        //event handler
        public static void b1ProcessCompleted(object sender,EventArgs e)
        {
            Console.WriteLine("Process Completed");
        }
    }
}
