using System;
using System.Collections.Generic;

namespace Complier
{
    class Program
    {
        static void Main(string[] args)
        {
            string token="";
            string lexeme;
            List<string> lines = new List<string>();
            try
            {
                FileHandler.readFromFile(args[0], lines);
                if (lines.Count <= 0)
                {
                    Console.WriteLine("File Name: ");
                    string fileName = Console.ReadLine();
                    FileHandler.readFromFile(fileName, lines);
                }
            }
            catch
            {
                Console.WriteLine("File Name: ");
                string fileName = Console.ReadLine();
                FileHandler.readFromFile(fileName, lines);
            }
           
            LexicalAnalyzer la = new LexicalAnalyzer(lines);
            Console.WriteLine(String.Format("{0, -20}{1,-20}", "Token", "Lexeme"));
            while (token != "eoft")
            {
                (token, lexeme) = la.GetNextToken();
                Console.WriteLine(String.Format("{0, -20}{1,-20}", token, lexeme));
            }
        } 
    }
}
