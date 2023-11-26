class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsHungry { get; set; }

    public Animal(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
        IsHungry = true;
    }

    // virtual - for methods that can be override
    public virtual void MakeSound()
    {
        
    }

    public virtual void Eat()
    {
        if(IsHungry)
        {
            Console.WriteLine($"{Name} is eating!");
        }else{
            Console.WriteLine($"{Name} is not hungry.");
        }
    }
    
    public virtual void Play()
    {
        Console.WriteLine($"{Name} is playing.");
    }
}