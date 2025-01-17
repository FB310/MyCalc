﻿
using MathsGame.Models;
using System.Security.AccessControl;

namespace MathsGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {

            Random num = new Random();
            int score = 0;


            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int firstNumber = num.Next(1, 9);
                int secondNumber = num.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                string result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct!Type any key for the next question!");
                    score++;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect!");
                    Console.ReadKey();


                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu");
                    Console.ReadKey();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);
        }

        internal void SubtractionGame(string message)
        {


            Random num = new Random();
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int firstNumber = num.Next(1, 9);
                int secondNumber = num.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                string result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct!Type any key for the next question!");
                    score++;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect!");
                    Console.ReadKey();


                }
                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu");
                    Console.ReadKey();
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void MultiplicationGame(string message)
        {
            Random num = new Random();
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int firstNumber = num.Next(1, 9);
                int secondNumber = num.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                string result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct!Type any key for the next question!");
                    score++;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect!Type any key for the next question!");
                    Console.ReadKey();

                }
                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score} . Press any key to go back to the main menu");
                    Console.ReadKey();
                }
            }

            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void DivisionGame(string message)
        {
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int[] divisionNumbers = Helpers.GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                string result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct!Type any key for the next question!");
                    score++;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect!Type any key for the next question!");
                    Console.ReadKey();

                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu ");
                    Console.ReadKey();
                }

            }
            Helpers.AddToHistory(score, GameType.Division);
        }

    }
}
