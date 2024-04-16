// See https://aka.ms/new-console-template for more information
using System;
using Radio_Room;


Console.WriteLine("Hello, World!");

Console.WriteLine("Welcome to the Radio Room");
Console.Write("Press any key to continue or 'enter' to stop.");    

if (Console.ReadKey().Key != ConsoleKey.Enter)
{
    Console.Write("Please enter the name you would like to be called during the game: ");

    // this is where the program would ask for what the player would like for their character,
    // choosing character type and name to be used,
    // maybe a second name?
    string userName = Console.ReadLine();

    Console.ReadKey();

    Console.ReadKey();
} else
{
    Environment.Exit(0);
};


