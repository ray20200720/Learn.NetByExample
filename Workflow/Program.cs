
using System.Activities;
using System.Activities.Statements;
using System.Activities.XamlIntegration;

namespace WorkflowExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var helloWorldActivity = new Sequence()
            {
                Activities =
                {
                    new WriteLine
                    {
                        Text = "Hello World!"
                    }
                }
            };

            System.Activities.WorkflowInvoker.Invoke(helloWorldActivity);
        }
    }
}
