using System;

class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} makes a sound");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Woof woof!");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}

class Cow : Animal
{
    public Cow(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Moo!");
    }
}

class Program
{
    static void Main()
    {
        Animal dog = new Dog("Buddy");
        Animal cat = new Cat("Whiskers");
        Animal cow = new Cow("Bessie");

        dog.MakeSound();
        cat.MakeSound();
        cow.MakeSound();

    }
}
