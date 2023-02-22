using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>(){
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"};
        private Random _random = new Random();

        public ListingActivity()
        {
            SetName("Listing Activity");
            SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        }

        public override void Start()
        {
            DisplayPrompt();
            UseTimer().Time("You may begin in", 5);
            CountUserResponse();
        }

        private void CountUserResponse()
        {
            DateTime futureTime = UseTimer().GetFutureTime(GetTimeLimit());
            int items = 0;

            while (!UseTimer().CheckHasTimePast(futureTime))
            {
                Console.Write("> ");
                Console.ReadLine();
                items++;
            }

            UseTimer().Pause($"You listed {items} items!", 5);
        }

        private void DisplayPrompt()
        {
            Console.WriteLine("List as many responses as you can to the following prompt:\n");
            Console.WriteLine($"---{_prompts[_random.Next(_prompts.Count)]}---\n");
        }
    }
}