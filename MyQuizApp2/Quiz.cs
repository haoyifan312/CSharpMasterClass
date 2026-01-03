using System;
using System.Collections.Generic;
using System.Text;

namespace MyQuizApp2
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _score;

        public Quiz(Question[] questions)
        {
            _questions = questions;
            _score = 0;
        }

        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------QUESTION----------");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; ++i)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("    ");
                Console.Write($"{i + 1}. ");
                Console.ResetColor();
                Console.WriteLine(question.Answers[i]);
            }


        }

        private int GetUserChoice()
        {
            Console.Write("Your answer (number): ");
            string input = Console.ReadLine();
            int choice = -1;
            while(!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine($"Invalid choice. Please enter a number between 1 and 4");
                input = Console.ReadLine();
            }
            return choice - 1;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!");

            int questionNumber = 1;
            _score = 0;
            foreach ( Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}:");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct!");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
                }
            }

            DisplayScore();
        }

        private void DisplayScore()
        {
            Console.WriteLine("--------RESULTS--------");
            Console.WriteLine($"Quiz finished! Your score is {_score} out of {_questions.Length}");
            double fraction = (double) _score / _questions.Length;
            if (fraction > 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excelent work!");
            }
            else if (fraction > 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good effort!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep working!");
            }
            Console.ResetColor();
        }
    }
}
