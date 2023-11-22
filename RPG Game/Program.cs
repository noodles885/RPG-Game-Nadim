using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            string path = @"Map.txt";
            string input = File.ReadAllText(path);
            Console.WriteLine();
            Console.WriteLine(path);
        }

    }

}
