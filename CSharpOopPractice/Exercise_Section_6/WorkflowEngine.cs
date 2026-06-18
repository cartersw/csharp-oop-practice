using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    public class WorkflowEngine
    {
        

        public static void Run(Workflow workflow)
        {
            foreach(var activity in workflow.Activities)
            {
                activity.Execute();
            }
        }

    }
}
