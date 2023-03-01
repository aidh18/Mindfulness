using System;

namespace Mindfulness
{
    public class Activity
    {
        private string _description;
        private string _name;
        private int _timeLimit;
        private Timer _timer = new Timer();

        public Activity()
        {
            
        }
        
        public virtual void Start() { }
        public void Complete() 
        {
            Console.Clear();

            Console.WriteLine("Well done!");
            _timer.Pause(5);

            Console.WriteLine($"You completed another {_timeLimit} seconds of the {_name}!");
            _timer.Pause(5);

            Console.Clear();
        }

        public void DoWelcome()
        {
            Console.WriteLine($"Welcome to the {_name}.\n");
            _timer.Count(3);
            Console.WriteLine($"{_description}\n");
            _timer.Count(3);

            Console.Write("How long, in seconds, would you like for your session? ");
            _timeLimit = Int32.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Get ready...");
            UseTimer().Pause(5);
            Console.Clear();
        }

        public string GetDescription()
        {
            return _description;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetTimeLimit()
        {
            return _timeLimit;
        }

        public void SetDescription(string description)
        {
            _description = description;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public Timer UseTimer()
        {
            return _timer;
        }
    }
}