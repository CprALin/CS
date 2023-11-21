using System.Collections;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // arrayListNonGeneric();
            listTest();
            
        }

        public static void listTest()
        {
            arrayListGeneric();

            foreach (var item in arrayListGeneric())
            {
                Console.WriteLine(item);
            }
        }

        public static List<int> arrayListGeneric()
        {
            List<int> list = new List<int>();

            for (int i = 100; i <= 170; i++)
            {
                if (i % 2 == 0)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public static void arrayListNonGeneric()
        {
            //declaring array list with undefined amout of objects 
            ArrayList myArrayList = new ArrayList();

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.4);
            myArrayList.Add(124);
            myArrayList.Add("World");
            myArrayList.Add(13.14);

            //remove element with specific value
            myArrayList.Remove(25);

            //remove element at specific position
            myArrayList.RemoveAt(0);


            Console.WriteLine(myArrayList.Count);
            double sum = 0;
            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);

        }
    }
}