﻿using System;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

//Zork Version 2.1
namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFileName = "Zork.json";
            string gameFileName = (args.Length > 0 ? args[(int)CommandLineArguments.GameFileName] : defaultGameFileName);

            Game game = Game.Load(gameFileName);
            Console.WriteLine("Welcome to Zork!");
            game.Run();
            Console.WriteLine("Thank you for playing!");
        }

        private enum CommandLineArguments
        {
            GameFileName = 0
        }
    }
}
