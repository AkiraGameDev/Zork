using System;
using System.Linq;

//Zork Version 2.1
namespace Zork
{
    class Program
    {
        private static string CurrentRoom
        {
            get
            {
                return Rooms[LocationColumn];
            }
            set
            {
                for(int column = 0; column < Rooms.Length; column++)
                {
                    if(Rooms[column] == value)
                    {
                        LocationColumn = column;
                       ;
                    }
                }

                throw new Exception("Room not found.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            string outputString;
            Commands command = Commands.UNKNOWN;
            CurrentRoom = "West of House";

            while (command != Commands.QUIT)
            {
                Console.WriteLine($"{CurrentRoom}\n> ");
                command = ToCommand(Console.ReadLine().Trim());
                
                switch(command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

                    case Commands.LOOK:
                        outputString = "This is an open field west of a white house, with a boarded front door.\nA rubber mat saying 'Welcome to Zork!' lies by the door.";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        if (Move(command)) outputString = $"You moved {command}.";
                        else outputString = $"The way is shut!";
                        break;

                    default:
                        outputString = "Unknown command.";
                        break;
                }

                Console.WriteLine(outputString);
            }
        }

        private static bool Move(Commands command)
        {
            Assert.IsTrue(IsDirection(command), "Invalid direction.");

            bool isValidMove = false;

            //(for Zork 2.1) excluded default, north and south cases because they simply reassign 
            // isValidMove to false I assume this is faster because we are searching for less cases
            switch (command)
            {
                case Commands.EAST when LocationColumn < Rooms.Length - 1:
                    LocationColumn++;
                    isValidMove = true;
                    break;
                case Commands.WEST when LocationColumn > 0:
                    LocationColumn--;
                    isValidMove = true;
                    break;
            }

            return isValidMove;
        }

        private static Commands ToCommand(string commandString) =>
            Enum.TryParse(commandString, ignoreCase: true, out Commands result) ? result : Commands.UNKNOWN;

        private static bool IsDirection(Commands command) => Directions.Contains(command);

        private static readonly string[] Rooms = 
        {   
            "Forest", 
            "West of House", 
            "Behind House", 
            "Clearing", 
            "Canyon View" 
        };

        //stuck with the array here because it's a simpler structure, and i believe it's faster
        private static readonly Commands[] Directions =
        {
            Commands.NORTH,
            Commands.SOUTH,
            Commands.EAST,
            Commands.WEST
        };

        private static int LocationColumn = 1;
    }
}
