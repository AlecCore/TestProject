using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\password.txt");
            List<PasswordData> passwordDatas = new List<PasswordData>();
            int lineNumber = 0;
            foreach (var line in lines)
            {
                try
                {
                    lineNumber++;
                    passwordDatas.Add(new PasswordData
                    {
                        SearchChar = line[0],
                        MinLenght = line[2] - '0',
                        MaxLenght = line[4] - '0',
                        Password = line.Substring(7)
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nError processing line {line}\n ErrorMessage: {ex}");
                }
            }
            int correctPasswordCount = 0;
            foreach (var passwordData in passwordDatas)
            {
                int searchCharCount = passwordData.Password.Count(x => x == passwordData.SearchChar);
                if (searchCharCount >= passwordData.MinLenght && searchCharCount <= passwordData.MaxLenght)
                    correctPasswordCount++;

            }
            Console.WriteLine($"Correct passwords: {correctPasswordCount}");

        }
    }
}
