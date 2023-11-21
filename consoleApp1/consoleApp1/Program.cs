namespace consoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car audi = new Car("Audi",130,"black");
            Car bmw = new Car("BMW",350);

            myCar.Name = "Volvo";
            myCar.MaxSpeed = 150;
            Console.WriteLine($"Max speed for {myCar.Name} is {myCar.MaxSpeed}");
            Console.WriteLine($"The car name is {myCar.Name}");
            /*
            myCar.setName("Volvo best car");
            Console.WriteLine(myCar.getName());
            */  
            myCar.Details();
            audi.Details();
            audi.Drive();
            bmw.Drive();
            
            Console.WriteLine("Press 1 to stop the car.");
            string input = Console.ReadLine();
            if(input == "1")
            {
                audi.Stop();
            }
            else
            {
                Console.WriteLine("Car drives indefinetely.");
            }
        }
    }
}