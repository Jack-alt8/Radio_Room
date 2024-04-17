// See https://aka.ms/new-console-template for more information
using System;
using Radio_Room;


Console.WriteLine("Hello, World!");

Console.WriteLine("Welcome to the Radio Room");
Console.Write("Press any key to continue or 'enter' to stop."); 

string userInput = Console.ReadLine();  

if (Console.ReadKey().Key != ConsoleKey.Enter)
{
    Console.Write("Please enter the name you would like to be called during the game: ");

    string userName = Console.ReadLine();

    Console.WriteLine($"Welcome, {userName}");
    /*TODO
    * this is where the program would ask for what the player would like for their character: 
    * choosing character type and name to be used, 
    * maybe a second name?
    * create a separate console.readline for decision making (y or n, or should it be typing the answer?)
    * create a single story narrative, with various decisions
    * look at reference repo
    */
    
} else
{
    Environment.Exit(0);
};


