using System;
using System.Collections.Generic;

namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rollDice, sagar = 0, akshay = 0;
            int count = 0;

         
            Random random = new Random();
         
            var list = new List<string> { "No Play", "Ladder", "Snake" };
            


            int playerChange = 1;
            while (sagar <= 100 || akshay <= 100)
            {
                
                Console.WriteLine("Player: " + playerChange + " is playing \n");

                rollDice = random.Next(1, 7);
                Console.WriteLine("Dice number is : " + rollDice + "\n");

                Console.WriteLine("Player checks options 1.No Play  2.Ladder   3.Snake \n");

                int index = random.Next(list.Count);
                Console.WriteLine("Player option is : " + list[index] + "\n");

                if (playerChange == 1)
                {
                    if (list[index] == "No Play" && playerChange == 1)
                    {
                        playerChange = 2;
                        continue;
                    }

                    if (list[index] == "Snake")
                    {
                        sagar -= rollDice;
                        playerChange = 2;
                    }

                    if (sagar + rollDice < 100 && playerChange == 1)
                    {
                        if (list[index] == "Ladder") sagar += rollDice;
                    }

                    if (list[index] == "Ladder" && (sagar + rollDice == 100) && playerChange == 1)
                    {
                        sagar += rollDice;
                        break;
                    }

                    if (sagar < 0 && list[index] == "Snake")
                    {
                        sagar = 0;
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine("Sagar current position : " + sagar);
                }

                else if (playerChange == 2)
                {
                    if (list[index] == "No Play" && playerChange == 2)
                    {
                        playerChange = 1;
                        continue;
                    }

                    if (akshay + rollDice < 100 && playerChange == 2)
                    {
                        if (list[index] == "Ladder") akshay += rollDice;
                    }

                    if (list[index] == "Snake")
                    {
                        akshay -= rollDice;
                        playerChange = 1;
                    }

                    if (list[index] == "Ladder" && (akshay + rollDice == 100) && playerChange == 2)
                    {
                        akshay += rollDice;
                        break;
                    }

                    if (akshay < 0 && list[index] == "Snake")
                    {
                        akshay = 0;
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine("Player 2 current position : " + akshay);
                    count++;
                }
            }
            Console.WriteLine("\n");
        


            Console.WriteLine("FINAL RESULT :");
            Console.Write("\n");
            if (sagar == 100)
            {
                Console.WriteLine("Winner is player 1  :" + sagar);
                Console.WriteLine("Final position of player 2  :" + akshay);
            }
            else
            {
                Console.WriteLine("Winner is player 2  :" + akshay);
                Console.WriteLine("Final position of player 1  :" + sagar);
            }
            
            Console.WriteLine("Number of times game played :" + count);
        }
    }
}
