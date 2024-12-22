/*
    Liskov Substitution Principle (LSP) : 
        Objects of a superclass should be replaceable with objects of a subclass without 
        affecting the correctness of the program
*/

namespace Liskov_Substitution_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liskov Substitution Principle");
        }
    }
}

namespace Bad_Way
{
    public class Bird
    {
        public virtual void Fly()
        {
            // Birds can fly
        }
    }

    public class Sparrow : Bird
    {
        public override void Fly()
        {
            // Fly
        }
    }

    /*
        Ostrich is Narrowing down the functionality of Bird
        as on using Fly it is throwing an exception
    */
    public class Ostrich : Bird
    {
        public override void Fly()
        {
            throw new Exception("Ostriches can't fly!");
        }
    }
}


namespace Good_Way
{
    public abstract class Bird
    {
        // Common properties or methods for all birds
    }

    public abstract class FlyingBird : Bird
    {
        public abstract void Fly();
    }

    public abstract class NonFlyingBird : Bird
    {

    }

    public class Sparrow : FlyingBird
    {
        public override void Fly()
        {
            // Sparrow flying
        }
    }

    public class Ostrich : Bird
    {

    }
}