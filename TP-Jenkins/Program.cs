using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CLSCompliant(true)]
namespace TPJenkins
{
    /// <summary>
    /// Main class
    /// </summary>    
    public static class Program
    {
        /// <summary>
        /// Entry of the program
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Hello World");
        }

        /// <summary>
        /// Funtion to add two number
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Function to divide two number
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Div(int a, int b)
        {
            return a / b;
        }
    }
}
