using System;
using System.Collections.Generic;
using System.Linq;

// This is MSA (Monopoly Save Algorithm)

namespace MSA_creator
{
    public class player
    {
        public int money;
        public int tokenID;
        public string name;
        public List<int> properties;
    }
    internal class Program
    {
        public static int[] ArrAppend(int[] array, string text)
        {
            List<int> list = array.ToList();
            list.Add(Convert.ToInt16(text));
            return list.ToArray();
        }

        public static void Main(string[] args)
        {
            bool isPlaying;
            int[] gameSetting = [];

            // Checks Starting money and appends
            Console.WriteLine("Enter Starting Money: ");
            try
            {
                string input = Console.ReadLine();
                gameSetting = ArrAppend(gameSetting, input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // Checking Amount of players
            Console.WriteLine("Enter Amount of players: ");
            try
            {
                string input = Console.ReadLine();
                gameSetting = ArrAppend(gameSetting, input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            Console.WriteLine(string.Join(", ", gameSetting));
            // Give names and assign players tokens
            for (int i = 0; i < gameSetting[1]; i++)
            {

            }
            
            gameSetting = ArrAppend(gameSetting, "0"); // "meh too" is not a valid integer, replaced with "0"
            
        }
    }
}
