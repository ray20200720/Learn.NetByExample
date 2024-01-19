using System.Activities;

namespace WorkflowExample
{
    public sealed class DiceRoll : CodeActivity
    {
        public OutArgument<int> D1 { get; set; }
        public OutArgument<int> D2 { get; set; }

        static Random random = new Random();
        
        protected override void Execute(CodeActivityContext context)
        {
            D1.Set(context, random.Next(1, 7));
            D2.Set(context, random.Next(1, 7));
        }
    }
}