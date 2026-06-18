using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    public class Workflow
    {
        public readonly IList<IActivity> Activities = new List<IActivity>();

        public void AddActivity(IActivity activity)
        {
            Activities.Add(activity);
        }
    }
}
