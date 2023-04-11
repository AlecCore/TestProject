using System;
using System.IO;

namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\password.txt");
            Console.WriteLine(lines);
        }
    }
}
