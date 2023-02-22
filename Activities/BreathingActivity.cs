namespace Mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            SetName("Breathing Activity");
            SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        }

        public override void Start()
        {
            PromptBreathing();
        }

        private void PromptBreathing()
        {
            int repetitions = (GetTimeLimit() / 10) + 1;
            for (int i = 0; i < repetitions; i++)
            {
                UseTimer().Time("Breathe in...", 6);
                UseTimer().Time("Breathe out...", 4);
            }
        }
    }
}