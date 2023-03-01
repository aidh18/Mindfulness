using System;
using System.Threading;
using System.Collections.Generic;

namespace Mindfulness
{
    public class Timer
    {
        
        private List<string> _animation = new List<string>()
            {" = >>---> ", "  = >>--->", "   = >>---", "    = >>--", "     = >>-", 
            "      = >>", "       = >", "        = ", "         =", "          ",
            "          ", "          ", ">         ", "->        ", "-->       ",
            "--->      ", ">--->     ", ">>--->    ", " >>--->   ", "= >>--->  "};

        public bool CheckHasTimePast(DateTime futureTime)
        {
            DateTime currentTime = DateTime.Now;

            if (currentTime > futureTime)
            {
                return true;
            }
            return false;
        }

        public DateTime GetFutureTime(int seconds)
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(seconds);

            return futureTime;
        }
        public void Pause(int seconds)
        {

            for (int i = 0; i < seconds; i++)
            {    
                foreach (string frame in _animation)
                {
                    Console.Write(frame);
                    Thread.Sleep(50);
                    Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                }
            }
        }
        
        public void DisplayAnimation(string message, int seconds)
        {
            Console.WriteLine($"{message}");
            
            for (int i = 0; i < seconds; i++)
            {    
                foreach (string frame in _animation)
                {
                    Console.Write(frame);
                    Thread.Sleep(50);
                    Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                }
            }
        }

        public void Count(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        public void DisplayCountdown(string message, int seconds)
        {
            Console.Write($"{message} {seconds}");
            Thread.Sleep(1000);

            for (int i = seconds - 1; i > 0; i--)
            {
                Console.Write($"\b{i}");
                Thread.Sleep(1000);
            }

            Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
        }
    }
}