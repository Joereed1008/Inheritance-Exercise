using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance_Exercise
{
    public class Stack
    {
        ArrayList stacks = new ArrayList();
        public Stack()
        {

        }
        public void Push(object pushed)
        {
            if (pushed != null) { stacks.Add(pushed); }
            else
                throw new Exception("Fucking null? nob");
        }
        public void Pop()
        {
            if (stacks.Count > 0)
            {
                Console.WriteLine(stacks[stacks.Count - 1]);
                stacks.RemoveAt(stacks.Count - 1);
            }
        }
        public void Clear() { ArrayList stacks = new ArrayList(); }
    }
}