﻿using System;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

//Zork Version 2.1
namespace Zork
{
    class Program
    {
        private static Room CurrentRoom
        {
            get
            {
                return Rooms[Location.Row, Location.Column];
            }
        }

        static void Main(string[] args)
        {
            Commands command = Commands.UNKNOWN;

            Room previousRoom = null;
            string defaultRoomsFileName = "Rooms.json";
            string roomsFileName = (args.Length > 0 ? args[(int)CommandLineArguments.RoomsFileName] : defaultRoomsFileName);
            InitializeRoomDescription(roomsFileName);

            Console.WriteLine("Welcome to Zork!");

            while (command != Commands.QUIT)
            {
                Console.WriteLine($"{CurrentRoom}");
                if(previousRoom != CurrentRoom)
                {
                    Console.WriteLine(CurrentRoom.Description);
                    previousRoom = CurrentRoom;
                }

                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());
                
                switch(command)
                {
                    case Commands.QUIT:
                        Console.WriteLine("Thank you for playing!");
                        break;

                    case Commands.LOOK:
                        Console.WriteLine(CurrentRoom.Description);
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        if (!Move(command)) Console.WriteLine("The way is shut!");
                        break;

                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
            }
        }

        private static bool Move(Commands command)
        {
            Assert.IsTrue(IsDirection(command), "Invalid direction.");

            bool isValidMove = true;

            switch (command)
            {
                case Commands.NORTH when Location.Row < Rooms.GetLength(0) - 1:
                    Location.Row++;
                    break;
                case Commands.SOUTH when Location.Row > 0:
                    Location.Row--;
                    break;
                case Commands.EAST when Location.Column < Rooms.GetLength(1) - 1:
                    Location.Column++;
                    break;
                case Commands.WEST when Location.Column > 0:
                    Location.Column--;
                    break;
                default:
                    isValidMove = false;
                    break;
            }

            return isValidMove;
        }

        private static Commands ToCommand(string commandString) =>
            Enum.TryParse(commandString, ignoreCase: true, out Commands result) ? result : Commands.UNKNOWN;

        private static bool IsDirection(Commands command) => Directions.Contains(command);

        private static void InitializeRoomDescription(string roomsFileName) => Rooms = JsonConvert.DeserializeObject<Room[,]>(File.ReadAllText(roomsFileName));

        private static Room[,] Rooms;

        //stuck with the array here because it's a simpler structure, and i believe it's faster
        private static readonly Commands[] Directions =
        {
            Commands.NORTH,
            Commands.SOUTH,
            Commands.EAST,
            Commands.WEST
        };

        private enum CommandLineArguments
        {
            RoomsFileName = 0
        }

        private static (int Row, int Column) Location = (1, 1);
    }
}
