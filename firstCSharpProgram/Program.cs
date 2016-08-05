using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstCSharpProgram
{   
    /// <summary>
    /// A Class That prints a message
    /// </summary>
    class Program
    {   
        /// <summary>
        /// Main method to print the message
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            Console.Write("Enter temperature (Fahrenheit): ");
            float originalFahrenheit = float.Parse(Console.ReadLine());
            float toCelcius = ((originalFahrenheit - 32)/9)*5;
            Console.WriteLine("\n Temperature in celcius is: "+toCelcius+"\n");
        }
    }
}
