using System;

namespace Constructors_Maxey_Andrew
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game = Datatype MyGame = name of the datatype, new = new object Game is type of object// Without manual input it will be unknown/ default
            Game myGame = new Game("Minecraft", "Open World");
            // myGame is the object and .title is a properity/variable to the object that can be pulled/called
            Console.WriteLine($"My favorite game is {myGame.title} and it is a {myGame.genre} game!");

            Game myOtherGame = new Game(":)",":(");

            Console.WriteLine($"My other favorite game is {myOtherGame.title} and it is a {myOtherGame.genre} game!");
        }
    }
}
