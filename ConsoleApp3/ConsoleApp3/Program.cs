namespace ConsoleApp3
{
    internal class Program
    {
        static int[,] matrix =
        {
            {1,2,3},
            {4,5,6}, 
            {7,8,9}
        };

        static void Main(string[] args)
        {
            // startApp();

            // forEachArray();

            //twdArray();

            //nestedForLoop();

            //diagonal();

            //diagonalSingleLoop();

            secDiag();

            Console.ReadKey();
        }

        private static void nestedForLoop()
        {
            foreach (var matrix in matrix)
            {
                Console.Write(matrix + " ");
            }

            Console.WriteLine("This is our 2D arrray printed using for loop");
            //nested for loop
            //outer for loop
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                //inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                  
                }
            }
        }

        private static void diagonalSingleLoop()
        {
            for(int i = 0; i < matrix.GetLength(0);i++)
            {
                Console.Write(matrix[i,i]);
            }

        }

        private static void secDiag()
        {
            Console.WriteLine("Sec Diag : ");
            for (int i = 0 , j = 2 ; i < matrix.GetLength(0) ; i++ , j--)
            {
                Console.WriteLine(matrix[i,j]);
            }
        }

        private static void diagonal()
        {
            Console.WriteLine("Diagonal is : ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine(" ");
            }
        }

        private static void startApp()
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 30;
            grades[3] = 25;
            grades[4] = 50;

            Console.WriteLine($"Grades at index 0 : {grades[0]}");


            string input = Console.ReadLine();
            grades[0] = int.Parse(input);

            Console.WriteLine($"Grades at index 0 : {grades[0]}");

            int[] gradesOfMathStudents = { 0, 12, 13, 14, 15, };
            Console.WriteLine($"Length of gradesOfMathStudents : {gradesOfMathStudents.Length}");
        }

        private static void forEachArray()
        {
            int[] nums = new int[10];

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;    
            }

            for(int j  = 0; j < nums.Length; j++)
            {
                Console.WriteLine($"Element {j} = {nums[j]}");
            }

            int counter = 0;
            foreach(int k in nums)
            {
                Console.WriteLine($"Element {counter} = {k}");
                counter++;
            }

            string[] friends = new string[5];

            Console.WriteLine("Enter five friends: ");
            for (int i = 0; i < friends.Length; i++)
            {
                friends[i] = Console.ReadLine();
            }

            for(int k = 0; k < friends.Length; k++)
            {
                Console.WriteLine($"Hello {friends[k]}");
            }

            string? input;
            do
            {
                Console.WriteLine("Enter a valid number: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out _));


        }

        private static void twdArray()
        {
            //declare 2d array
            string[,] matrix;
            //3D array
            int[,,] arrayTghreeD;

            arrayTghreeD = new int[,,]
            {
                {
                    {1,2,3 },
                    {4,5,6}
                },
                {
                    {3,4,5},
                    {5,6,7}
                }
            };

            Console.WriteLine($"Value for 3D array : {arrayTghreeD[0,1,1]}");

            string[,] array2dString = new string[3, 2] 
            {
                {"one","two" },
                {"one","twoPoz" },
                {"one","two" }
            };

            Console.WriteLine($"Array 2d string {array2dString[1,1]}");
            int dimensions = array2dString.Rank + 1;
            Console.WriteLine($"Dimensions : {dimensions}");

            int[,] array2D = new int[,] 
            {
               { 1,2,3},
               { 2,3,4},
               { 3,4,5}
            };

            Console.WriteLine($"Central value is {array2D[1,1]}");
        }
    }
}