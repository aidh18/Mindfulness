using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts = new List<string>(){
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."};
        private List<string> _questions = new List<string>(){
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"};
        private Random _random = new Random();

        public ReflectingActivity()
        {
            SetName("Reflecting Activity");
            SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        }

        public override void Start()
        {
            DisplayPrompt();

            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            UseTimer().Time("You may begin in", 5);
            
            DisplayQuestions();
        }

        private void DisplayPrompt()
        {
            Console.WriteLine("Consider the following prompt:\n");
            Console.WriteLine($"---{_prompts[_random.Next(_prompts.Count)]}---\n");
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
        }

        private void DisplayQuestions()
        {

            int numberOfQuestions = (GetTimeLimit() / 10) + 1;
            for (int i = 0; i < numberOfQuestions; i++)
            {
                UseTimer().Pause("> " +_questions[_random.Next(_questions.Count)], 10);
            }
        }
    }
}