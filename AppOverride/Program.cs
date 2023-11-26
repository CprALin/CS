namespace AppOverride;

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog("Sif", 12);
    
        Console.WriteLine($"{myDog.Name} is {myDog.Age} years old!");

        myDog.Play();
        myDog.Eat();
        myDog.MakeSound();
    }
}
