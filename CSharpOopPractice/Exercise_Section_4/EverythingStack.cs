using System.Collections;

namespace CSharpIntermediate
{
    public class EverythingStack
    {
        private readonly ArrayList _everythingStack;
        public EverythingStack()
        {
            _everythingStack = new ArrayList();
        }

        public void Push(object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException("Error: " + nameof(obj) + " was null!");
            }
            _everythingStack.Add(obj);
        }

        public object Pop()
        {
            if(_everythingStack.Count == 0)
            {
                throw new InvalidOperationException("Error: Stack is empty");
            }
            object obj = _everythingStack[_everythingStack.Count - 1];
            _everythingStack.RemoveAt(_everythingStack.Count - 1);
            return obj;
        }
        
        public void Clear()
        {
            int count = _everythingStack.Count;
            while(_everythingStack.Count > 0)
            {
                _everythingStack.RemoveAt(_everythingStack.Count - 1);
            }
            Console.WriteLine(count + " items removed.");
        }

    }
}