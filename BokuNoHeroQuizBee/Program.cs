using System;
using System.Collections.Generic;

namespace AnimeQuiz
{
    class MhaQuiz
    {
        static void Main(string[] args)
        {
            int score = 0;
            int chances = 2; 
            List<Question> questions = new List<Question>
            {
                new Question(1, "Who is the main protagonist of My Hero Academia?", "Izuku Midoriya", new List<string>{"It's fine now. Why? Because I am here!"}),
                new Question(2, "What is Izuku Midoriya's hero name?", "Deku", new List<string>{"I'm not gonna be your worthless punching bag," +
                " Deku forever. Kacchan, I'm... I'm the Deku who always does his best!", "A smiling... dependable... cool hero... That's what I wanna be! That's why I'm giving it everything! For everyone!",
                "I'm Deku! I'm the Deku who always does his best!",}),
                new Question(3, "Who is known as the Symbol of Peace?", "All Might",
                new List<string>{"It's fine now. Why? Because I am here!"}),
                new Question(4, "What is the name of the school where the characters train to become heroes?", "U.A. High School",
                new List<string>{"Plus Ultra!"}),
                new Question(5, "Which character can create explosions using his sweat?", "Katsuki Bakugo",

                new List<string>{"DIE!","Geez! Why are you acting so damn cool, Deku?!","I'll kill you!"}),
                new Question(6, "What is the name of Shoto Todoroki's father, who has both ice and fire quirks?", "Endeavor", new List<string>{"I have to live up to everyone's expectations! I have to become a better hero than All Might!"})
            };

            Console.WriteLine("Welcome to the My Hero Academia Quiz!");
            Console.WriteLine("Let's see how well you know the anime.\n");

            foreach (var question in questions)
            {
                Console.WriteLine($"Question {question.Number}: {question.Text}");
                bool answeredCorrectly = false;
                for (int i = 0; i < chances; i++)
                {
                    string answer = Console.ReadLine();
                    if (answer.Equals(question.Answer, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Correct!");
                        score++;
                        answeredCorrectly = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect. Try again:");
                    }
                }
                if (!answeredCorrectly)
                {
                    Console.WriteLine($"Sorry, you didn't get it right. The correct answer is: {question.Answer}");
                }
                Console.WriteLine();
                
                Console.WriteLine($"Random Quote: {question.GetRandomQuote()}");
                Console.WriteLine();
            }

            Console.WriteLine($"Quiz Over! Your score is: {score}/{questions.Count}");
            Console.WriteLine("Thanks for playing!");
        }

        class Question
        {
            public int Number { get; }
            public string Text { get; }
            public string Answer { get; }
            private List<string> quotes;

            public Question(int number, string text, string answer, List<string> quotes)
            {
                Number = number;
                Text = text;
                Answer = answer;
                this.quotes = quotes;
            }

            public string GetRandomQuote()
            {
                Random rand = new Random();
                return quotes[rand.Next(quotes.Count)];
            }
        }
    }
}
