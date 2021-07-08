using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeProblem
{
    class TicTacToeGame
    {
        //char human, computer;
        static char[] arr = new char[10];
        public static char[] IntializingCharArray()
        {
            //Initializing Char Array 

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ' ';
            }
            return arr;
        }
        public static void CreateBoard()
        {
            Console.WriteLine("***************************");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("*****************");

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
            if (human == 'x' || human == 'X')
                 computer= 'O';
               // return (Convert.ToChar(Convert.ToInt32(human)));
            else
            {
                computer = 'X';
                //return (Convert.ToChar(Convert.ToInt32(human)));
            }
            return computer;
        }
    }
}
