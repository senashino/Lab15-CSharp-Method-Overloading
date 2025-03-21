using static System.Console;

var animalA = new Dog();
var animalB = new Fish();
var animalC = new Bird();

animalA.Move();
animalB.Move();
animalC.Move();

class Animal
{
    // Virtual method to be overridden by derived classes
    public virtual void Move()
    {
        WriteLine("Move successfully.");
    }
}

class Dog : Animal
{
    // Overriding Move method for Dog
    public override void Move()
    {
        WriteLine($"{this.GetType()}: Running on the ground.");
    }
}

class Fish : Animal
{
    // Overriding Move method for Fish
    public override void Move()
    {
        WriteLine($"{this.GetType()}: Swimming in the water.");
    }
}

class Bird : Animal
{
    // Overriding Move method for Bird
    public override void Move()
    {
        WriteLine($"{this.GetType()}: Flying in the air.");
    }
}
