
using System.Activities;
using System.Activities.Statements;
using System.Activities.XamlIntegration;

namespace WorkflowExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/UiPath/CoreWF/blob/develop/README.md
            
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
            

            // https://learn.microsoft.com/zh-cn/dotnet/framework/windows-workflow-foundation/using-workflowinvoker-and-workflowapplication

            /*
            Activity wf1 = new WriteLine
            {
                Text = "Hello"
            };

            WorkflowInvoker.Invoke(wf1);
            */

            /*
            Activity wf2 = new Sequence()
            {
                Activities =
                {
                    new WriteLine()
                    {
                        Text = "Before the 1 minute delay."
                    },
                    new Delay()
                    {
                        Duration = TimeSpan.FromMinutes(1)
                    },
                    new WriteLine()
                    {
                        Text = "After the 1 minute delay."
                    }
                }
            };

            // This workflow completes successfully.
            WorkflowInvoker.Invoke(wf2, TimeSpan.FromMinutes(2));

            // This workflow does not complete and a TimeoutException
            // is thrown.
            try
            {
                WorkflowInvoker.Invoke(wf2, TimeSpan.FromSeconds(30));
            }
            catch (TimeoutException ex)
            {
                Console.WriteLine(ex.Message);
            }
            */
        }
    }
}
