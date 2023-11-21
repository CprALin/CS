namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //staks();

            reverse();
        }

        public static void reverse()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            Stack<int> stack = new Stack<int>();
            
            //foreach number in my array
            foreach (int i in numbers)
            {
                //print it
                Console.WriteLine(i + " ");
                //push it into our stack
                stack.Push(i);
            }

            Console.WriteLine("");
            Console.WriteLine("The numbers in reverse: ");

            while(stack.Count > 0)
            {
                //pop it and store it in a variable
                int number = stack.Pop();
                //print the value we popped
                Console.Write(number + " ");
            }
        }

        public static void staks()
        {
            //defining a new stack
            Stack<int> ints = new Stack<int>();

            if(ints.Count > 0 )
            {
                ints.Pop(); 
            }

            //add element to the stack
            ints.Push(1);
            Console.WriteLine($"Top value int the stack is : {ints.Peek()}");
            ints.Push(133);
            //Peek() - will return the element at the top of the stack without removing it
            Console.WriteLine($"Top value int the stack is : {ints.Peek()}");
            ints.Push(34);
            // Pop() - remove an item
            int myStackItem = ints.Pop();
            Console.WriteLine($"Pooped item : {myStackItem}");
            Console.WriteLine($"Top value int the stack is : {ints.Peek()}");

            while(ints.Count > 0)
            {
                Console.WriteLine($"Pooped item : {ints.Pop()}");
                Console.WriteLine($"Curent stack count is : {ints.Count}");
            }

        }
    }
}