using System.Collections;

namespace CSharpIntermediate
{
    public class EverythingStack
    {
        private ArrayList stack;
        public EverythingStack()
        {
            stack = new ArrayList();
        }

        public void Push(object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException("Error: " + nameof(obj) + "was null!");
            }
            stack.Add(obj);
        }

        public object Pop()
        {
            if(stack.Count == 0)
            {
                throw new InvalidOperationException("Error: Stack is empty");
            }
            object obj = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return obj;
        }
        
        public void Clear()
        {
            while(stack.Count > 0)
            {
                stack.RemoveAt(stack.Count - 1);
            }
        }

    }
}