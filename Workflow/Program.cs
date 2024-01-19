
using System.Activities;
using System.Activities.Statements;
using System.Activities.XamlIntegration;

namespace WorkflowExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region https://github.com/UiPath/CoreWF/blob/develop/README.md
            /*
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
            */
            #endregion

            #region https://learn.microsoft.com/zh-cn/dotnet/framework/windows-workflow-foundation/using-workflowinvoker-and-workflowapplication

            /*
            Activity wf = new WriteLine
            {
                Text = "Hello"
            };

            WorkflowInvoker.Invoke(wf);
            */

            /*
            Activity wf = new Sequence()
            {
                Activities =
                {
                    new WriteLine()
                    {
                        Text = "Before the 1 minute delay."
                    },
                    new Delay()
                    {
                        Duration = TimeSpan.FromMinutes(0.5)
                    },
                    new WriteLine()
                    {
                        Text = "After the 1 minute delay."
                    }
                }
            };

            // This workflow completes successfully.
            WorkflowInvoker.Invoke(wf, TimeSpan.FromMinutes(1));

            // This workflow does not complete and a TimeoutException
            // is thrown.
            try
            {
                WorkflowInvoker.Invoke(wf, TimeSpan.FromSeconds(30));
            }
            catch (TimeoutException ex)
            {
                Console.WriteLine(ex.Message);
            }
            */

            /*
            Activity wf3 = new WriteLine();

            Dictionary<string, object> inputs = new Dictionary<string, object>();
            inputs.Add("Text", "Hello World.");

            WorkflowInvoker.Invoke(wf3, inputs);
            */

            /*
            int dividend = 500;
            int divisor = 36;

            Dictionary<string, object> arguments = new Dictionary<string, object>();
            arguments.Add("Dividend", dividend);
            arguments.Add("Divisor", divisor);

            IDictionary<string, object> outputs = WorkflowInvoker.Invoke(new Divide(), arguments);

            Console.WriteLine("{0} / {1} = {2} Remainder {3}", dividend, divisor, outputs["Result"], outputs["Remainder"]);
            */

            // 使用 WorkflowApplication
            /*
            AutoResetEvent syncEvent = new AutoResetEvent(false);
            Activity wf4 = new WriteLine
            {
                Text = "Hello World."
            };

            WorkflowApplication wfApp = new WorkflowApplication(wf4);

            wfApp.Completed = delegate (WorkflowApplicationCompletedEventArgs e)
            {
                syncEvent.Set();
            };

            wfApp.Run();

            syncEvent.WaitOne();
            */

            // 設定工作流程的輸入引數
            /* 
            AutoResetEvent syncEvent = new AutoResetEvent(false);
            Activity wf5 = new WriteLine();

            Dictionary<string, object> inputs = new Dictionary<string, object>();
            inputs.Add("Text", "Hello World!");

            WorkflowApplication wfApp = new WorkflowApplication(wf5, inputs);

            wfApp.Completed = delegate (WorkflowApplicationCompletedEventArgs e)
            {
                syncEvent.Set();
            };

            wfApp.Run();

            syncEvent.WaitOne();
            */


            //擷取工作流程的輸出引數
            /*
            AutoResetEvent syncEvent = new AutoResetEvent(false);

            WorkflowApplication wfApp = new WorkflowApplication(new DiceRoll());

            wfApp.Completed = delegate(WorkflowApplicationCompletedEventArgs e)
            {
                if(e.CompletionState == ActivityInstanceState.Faulted)
                {
                    Console.WriteLine("Workflow {0} Terminated.", e.InstanceId);
                    Console.WriteLine("Exception: {0}\n{1}", 
                        e.TerminationException.GetType().FullName,
                        e.TerminationException.Message);
                }
                else if(e.CompletionState == ActivityInstanceState.Canceled)
                {
                    Console.WriteLine("Workflow {0} Canceled.", e.InstanceId);
                }
                else
                {
                    Console.WriteLine("Workflow {0} Completed.", e.InstanceId);

                    // Outputs can be retrieved from the Outputs dictionary,
                    // keyed by argument name.
                    Console.WriteLine("The two dice are {0} and {1}.",
                        e.Outputs["D1"], e.Outputs["D2"]);
                }
                syncEvent.Set();
            };

            wfApp.Run();
            syncEvent.WaitOne();
            */
            #endregion

            #region ActivityXamlServices.Load 需要安裝 UiPath.Workflow
            // 讀取 xaml 字串
            // string xamlString = "<Activity xmlns=\"http://schemas.microsoft.com/netfx/2009/xaml/activities\"><Sequence><WriteLine Text=\"Hello World!\" /></Sequence></Activity>";
            // Activity activity = ActivityXamlServices.Load(new StringReader(xamlString));

            // var helloWorldActivity = ActivityXamlServices.Load(new StringReader(xamlString));
            // System.Activities.WorkflowInvoker.Invoke(helloWorldActivity);

            // 讀取 Workflow1.xaml
            using (StreamReader sr = new StreamReader(@".\Workflow1.xaml"))
            {
                string line;
                string xamlString = string.Empty;

                while ((line = sr.ReadLine()) != null)
                {
                    xamlString += line;
                }

                var helloWorldActivitys = ActivityXamlServices.Load(new StringReader(xamlString));
                WorkflowInvoker.Invoke(helloWorldActivitys);
            }
            #endregion
        }
    }
}
