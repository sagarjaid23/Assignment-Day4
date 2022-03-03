using System;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();  
            int diceroll = rnd.Next(1,7);
            Console.WriteLine(diceroll);
        }
    }
}
