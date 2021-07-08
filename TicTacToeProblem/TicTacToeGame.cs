using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeProblem
{
    class TicTacToeGame
    {//UC1
        //char human, computer;
        public static char[] IntializingCharArray()
        {
            //Initializing Char Array 
            char[] arr = new char[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ' ';
            }
            return arr;
        }
        public static void DisplayBoard(char[] arr)
        {
            Console.WriteLine("***************************");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("**********************");

        }

        //Get 
        public static char GetHumanInput()
        {
            char human;
            Console.WriteLine("Enter the character either X or O");
            human = Convert.ToChar(Console.ReadLine());
            return human;
        }
        public static char GetComputerInput(char human)
        {
            char computer;
            if (human == 'X' || human == 'X')
                computer = 'O';
            else
            {
                computer = 'X';
            }
            return computer;
        }
        public static void GetInit(char[] arr, char human)
        {
            while (true)
            {
                Console.WriteLine("Enter the position from 1 to 9 :");
                int pos = Convert.ToInt32(Console.ReadLine());
                if (arr[pos] != 'X' && arr[pos] != 'O')
                {
                    arr[pos] = human;
                    break;
                }
                else
                {
                    Console.WriteLine("Already Ocuupied.Try Different Position!");
                }
            }

            TicTacToeGame.DisplayBoard(arr);
        }
    }

}

