class Dog : Animal
{
    public bool IsHappy { get; set; }

    public Dog(string Name, int Age):base(Name,Age)
    {
        this.IsHappy = true;
    }

    //simple override of the virtual method Eat
    public override void Eat()
    {
        //to call the eat method we need to use base
        base.Eat();
    }

    //override the method MakeSound
    public override void MakeSound()
    {
        Console.WriteLine("Wuuf!");
    }

    public override void Play()
    {
        if(IsHappy)
        {
            base.Play();
        }else{
            Console.WriteLine("Is sleeping!");
        }
    }
}