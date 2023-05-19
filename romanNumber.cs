public class romanNumber {
    public static int romanToInt(string s){
       int number = 0;
    
       for(int i=0; i < s.Length ; i++){
            int currentValue = romanNumb(s[i]);

            number += currentValue;
       }
       
       return number;
    }

    private static int romanNumb(char c){
        switch(c){
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
            default:
                throw new ArgumentException($"This roman number is invalid: {c}");                            
        }
    }

    public static void Main(String[] args){
        string? s;
        int romanNumb;

        Console.WriteLine("Enter the roman number: ");
        s = Console.ReadLine();
        
        if(s != null){
          romanNumb = romanToInt(s);

          Console.WriteLine($"Number is : {romanNumb}");
        }
    }
}