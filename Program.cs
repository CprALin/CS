public class targetSum {
    public static void doSum(int[] numbers,int target){

        for(int i= 0 ; i < numbers.Length - 1 ; i++){
            for(int j = i+1 ; j < numbers.Length;j++){
                if(numbers[i] + numbers[j] == target){
                    Console.Write("["+numbers[i] + " + " + numbers[j] + "]");
                }
            }
        }   
    }
    public static void Main(string[] args){
        Console.WriteLine("Enter the numbers: ");
        string? num = Console.ReadLine();
        if(num != null){
        string[] str = num.Split(" ");

        int[] numbers = new int[str.Length];

        for(int i=0; i<str.Length;i++){
            numbers[i] = int.Parse(str[i]);
        }

        Console.WriteLine("Numbers are: ");

        for(int i = 0; i<numbers.Length;i++){
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Enter a target: ");
        string? s;
        s = Console.ReadLine();
        if(s != null){
          int trg = int.Parse(s);

          Console.WriteLine($"Numbers with the target {trg}: ");
          doSum(numbers,trg);
        } 
        }

    }
}