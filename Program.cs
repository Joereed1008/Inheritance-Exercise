namespace Inheritance_Exercise
{
    internal class Program : Stack
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push("This is a stack");
            stack.Push(2.32);
            stack.Push("It takes loads of object types!");
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Clear();

            //boxing unboxing occurs due to use of arraylist
        }
    }
}