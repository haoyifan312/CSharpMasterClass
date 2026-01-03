namespace MyQuizApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question("What is the capital of Germany?",
                new string[] {"Peris", "Berlin", "London", "Madrid"},
                1
                ), 
                new Question("What is 2+2?", 
                new string[] {"1", "2", "4", "8"}, 
                2), 
                new Question("Who wrote 'Hamblet'?", 
                new string[] { "Shakespeare", "Goethe", "Austen", "Dickens"}, 
                0)
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
        }
    }
}
