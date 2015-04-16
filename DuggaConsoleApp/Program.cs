using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dugga
{
    class Program
    {
        static void Main(string[] args)
        {
            Shortcut sc = new Shortcut();

            while (true)
            {
                try
                {
                    Console.Write("Enter a string to convert: ");
                    var str = Console.ReadLine();
                    long result = sc.Convert(str);
                    Console.WriteLine("Result after conversion: " + result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
    }
}
