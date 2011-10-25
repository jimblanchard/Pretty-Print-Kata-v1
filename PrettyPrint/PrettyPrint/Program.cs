using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What directory would you like to process?");
            var target = Console.ReadLine();
            if (target == null) throw new Exception();
            var dirinfo = new System.IO.DirectoryInfo(target);
        }
    }
}
