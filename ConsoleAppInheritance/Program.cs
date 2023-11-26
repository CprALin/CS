namespace ConsoleAppInheritance;

class Program
{
    static void Main(string[] args)
    {
        Radio myRadio = new Radio(false, "Sony");
        //method of parent class
        myRadio.switchOn();
        //method of child class
        myRadio.listenRadio();

        TV myTv = new TV(false, "Samsung");
        myTv.switchOff();
        myTv.watchTV();
    }
}
