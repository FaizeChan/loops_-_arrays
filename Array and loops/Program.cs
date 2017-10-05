using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] favoriteHolidays = { "Halloween", "Thanksgiving", "New years", "Valentine's Day" };

            foreach (string holiday in favoriteHolidays)
            {
                Console.WriteLine(holiday);
            }

            //foreach loops are the ones that goes straight through
            //for loops is easier to read but more steps

            //for(int i = 0; i < favoriteHolidays.Length; i++)
            //{
            //    Console.WriteLine(favoriteHolidays[i]);
            //}


            //int[] multiplesOfThree = { 3, 6, 9, 12, 15, 18 };

            //int sum = 0;

            //foreach (int multiple in multiplesOfThree)
            //{
            //    sum += multiple;
            //}

            //for(int i = 0; i < multiplesOfThree.Length; i++)
            //{
            //    sum += multiplesOfThree[i];
            //}

            //Console.WriteLine(sum);

            string playAgain = "";

            do
            {

                Console.WriteLine("I love this game. What do you think?");
                string userOpinion = Console.ReadLine();

                Console.WriteLine("It was really fun to hang out. Don't you agree?");
                string userSatisfaction = Console.ReadLine();

                Console.WriteLine("Do you want to play again?");
                playAgain = Console.ReadLine().ToLower();
            } while (playAgain == "yes");


        }
    }
}
