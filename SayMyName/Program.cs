/*Ashton Tolman
 * RCET 2265
 * Spring 2026
 * https://github.com/Ashton-Tolman/SayMyName.git*/
using System.Reflection.Metadata;

namespace SayMyName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userinput;
            Console.WriteLine("What is your name?");
            userinput =Console.ReadLine();
            Console.WriteLine($"Your name is \"{userinput}\"");
            Console.Read();
        }
    }
}
