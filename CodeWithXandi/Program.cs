using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithXandi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random { };

            // Assign a random number for the computers guess
            int ComputersNumber = rd.Next(0, 11);

            bool Play = true;

            Console.Write("Enter your Guess: ");

            // Game Loop
            while (Play)
            {

                // Get a number from user
                string Input = Console.ReadLine();

                // Error checking - make sure user enters a integer
                int Result;
                if (int.TryParse(Input, out Result))
                {

                    // Compare user input to computers guess. End game if correct.

                    if (Convert.ToInt32(Input) > ComputersNumber)
                    {
                        Console.Write("Too High!");
                        Console.Write("\nEnter your Guess: ");
                    }

                    else if (Convert.ToInt32(Input) < ComputersNumber)
                    {
                        Console.Write("Too Low!");
                        Console.Write("\nEnter your Guess: ");
                    }

                    else
                    {
                        Console.Write("Correct!");

                        // end game.
                        Play = false;
                    }
                }

                else
                {
                    Console.Write("You didn't enter a number. Please enter a Number!\n");
                }
            }


        }   

    }
}
