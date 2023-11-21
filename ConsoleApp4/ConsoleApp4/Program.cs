namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // jaggerArrayIntro();
            // jaggerArrayFriends();
            // studentGrades();
            happiness();
        }

        public static void jaggerArrayIntro()
        {

            //declare jaggerArrary
            int[][] jaggerArray = new int[3][];

            jaggerArray[0] = new int[5];
            jaggerArray[1] = new int[3];
            jaggerArray[2] = new int[4];

            jaggerArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggerArray[1] = new int[] { 1, 2, 3 };
            jaggerArray[2] = new int[] { 1, 2, 3, 4 };

            //alternative way
            int[][] jaggerArray2 = new int[][]
            {
               new int[] {2,3,4,5,6},
               new int[] {3,4,5,7,8}
            };

            Console.WriteLine($"The value in the middle of the first entry is {jaggerArray[0][2]}");
            Console.WriteLine("All values from jaggerArray2");
            for (int i = 0; i < jaggerArray2.Length; i++)
            {
                for (int j = 0; j < jaggerArray2[i].Length; j++)
                {
                    Console.WriteLine($"Position [{i}][{j}] = {jaggerArray2[i][j]}");
                }
            }
        }

        public static void jaggerArrayFriends()
        {
            //you can create new array and store it in jaggerArray
            string[] joshFamily = new string[] { "Martha", "Robert"};

            string[][] friends = new string[][]
            {
                new string[] {"Michel","Sandy"},
                new string[] {"Frank","Claudia"},
                new string[] {"Andrew","Michel"},
                joshFamily
            };

            Console.WriteLine($"Hi {friends[0][0]} , I would like to introduce {friends[1][0]} to you.");
            Console.WriteLine($"Hi {friends[1][1]} , I would like to introduce {friends[2][0]} to you.");
            Console.WriteLine($"Hi {friends[0][1]} , I would like to introduce {friends[2][1]} to you.");

        }

        public static double getAvarage(double[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            double sum = 0;

            for(int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum / size;

            return average;
        }

        public static void sunIsShining(int[] happiness)
        {
            for(int i = 0; i < happiness.Length; i++)
            {
                happiness[i] += 2;
            }
        }

        public static void happiness()
        {
            int[] happiness = new int[] {1,2,3,4,5,6,7,8 };

            sunIsShining(happiness);  

            foreach(int i in happiness)
            {
                Console.WriteLine(i);
            }
        }

        public static void studentGrades()
        {
            double[] studentGrades = new double[] { 20, 15.4, 13.2, 8.6, 10, 12 };
            double avarageResult = getAvarage(studentGrades);

            foreach(double grade in studentGrades)
            {
                Console.Write(grade + " ");
            }

            Console.WriteLine($"The avarage of grades is : {avarageResult}");
        }
    }
}