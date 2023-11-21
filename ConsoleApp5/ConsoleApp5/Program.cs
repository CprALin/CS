namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // example();
            // sumExamples();
            // avarageExamples();

            checkMin();

        }

        public static void ParamsMethod(params string[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                Console.Write(args[i] + " ");
            }
        }

        public static void ParamObjMethod(params object[] args)
        {
            foreach(object obj in args)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();
        }

        public static void example()
        {
            int age = 20;
            char pref = '@';
            string strg = "Is a string";
            double d = 12.3;

            ParamsMethod("This", "is", "a", "string");
            ParamObjMethod($"You can add {age} and {pref} , {strg} , {d}");
            ParamObjMethod("Hello");
        }

        public static int Sum(params int[] args)
        {
            int total = 0;
            for(int i = 0; i < args.Length; i++)
            {
                total += args[i];
            }

            return total;

        }

        public static double Avarage(params int[] numbers) 
        {
            int total = 0;
            int count = 0;

            foreach(int i in numbers)
            {
                total += i;
                count++;
            }

            return (double)total / count;

        }

        public static void avarageExamples()
        {
            double total = Avarage(2,3,4,5,23);

            Console.WriteLine(total);
        }

        public static void sumExamples()
        {
            int sum = Sum(2, 5, 10, 8);
            Console.WriteLine(sum);
        }

        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach(int i in numbers)
            {
                if(i < min)
                {
                    min = i;
                }
            }

            return min; 
        }

        public static void checkMin()
        {
            int min = MinV2(6,4,2,1,10,9,7 , -11, -15);

            Console.WriteLine($"The min value is : {min}");
        }
    }
}