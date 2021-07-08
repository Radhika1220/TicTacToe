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
            char human = TicTacToeGame.GetHumanInput();
            char computer = TicTacToeGame.GetComputerInput(human);
            Console.WriteLine("Human has chosen {0} and computer has got {1}", human, computer);
            TicTacToeGame.CreateBoard();
            Console.ReadLine();
        }
    }
}
