using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to tic tac toe problem!");
            TicTacToeGame.IntializingCharArray();
            TicTacToeGame.CreateBoard();
            TicTacToeGame.GetInput();
            Console.ReadLine();
        }

    
    }
}
