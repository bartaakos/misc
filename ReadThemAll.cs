using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace readThemAll
{
    class ReadThemAll
    {
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            while (Console.In.Peek() != -1)
            {
                string input = Console.In.ReadLine();
                Console.WriteLine("Data read was " + input);
            }
        }
    }
}
