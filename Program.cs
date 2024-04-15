using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superlottothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // most current date and numbers for Florida Lotto
            string drawingDate = "28th, February, 2024";

            // array initialized with current winning lotto numbers
            int[] winningNumbers = { 4, 8, 32, 35, 37, 45 };

            Console.WriteLine($"Florida Lottery winning numbers - {drawingDate}");

            // prompt player for their number
            Console.WriteLine("Enter a lottery number between one and fifty: ");
            int.TryParse(Console.ReadLine(), out int playNumber); 

            // verify if player number is the winning number
            bool isWinner = winningNumbers.Contains(playNumber);

            if (isWinner)
            {
                Console.WriteLine("We have a winner!");
            }
            else
            {
                Console.WriteLine("We have a big loser!");
            }


        }
    }
}
