using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLTest {
    public class HelloWorld {
        public static void Main()
        {
            Console.WriteLine("Hello World");
            //closes the debugger on a key press
            Close();
        }

        private static void Close()
        {
            Console.WriteLine("\nPress Any Key To Close");
            Console.ReadKey();
        }
    }
}
