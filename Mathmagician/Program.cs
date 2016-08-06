﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface userInterface = new UserInterface();

            // Gets the user command and checks to see if its a valid command
            bool invalidCommandInput = true;
            bool invalidNumberInput = true;
            string userOperationCommand = "";
            string userStringOfValues = "";
            int userNumberOfValues = 0;

            // Gets the user 
            while (invalidCommandInput)
            {
                Console.Write("What would you like for me to do? ");
                userOperationCommand = Console.ReadLine().ToLower();
                invalidCommandInput = userInterface.CheckUserCommandInput(userOperationCommand);
            }

            while (invalidNumberInput)
            {
                Console.Write("How many should I print? ");
                userStringOfValues = Console.ReadLine();
                invalidNumberInput = userInterface.CheckUserNumberInput(userStringOfValues);
            }
            userNumberOfValues = Int32.Parse(userStringOfValues);

            Console.WriteLine($"\nCool, I'm going to print {userNumberOfValues} {userOperationCommand} numbers.");
            userInterface.InitiateNumberOperation(userOperationCommand, userNumberOfValues);
        }
    }
}
