/*
    Interface Segregation Principle (ISP) :
        Clients should not be forced to depend on interfaces they do not use. 
        Instead of one fat interface, multiple small, specific interfaces are 
        preferable
*/

namespace Interface_Segregation_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

namespace Bad_Way
{
    public interface IWorker
    {
        public void Work();
        public void Eat();
    }

    public class HumanWorker : IWorker
    {
        public void Work()
        {

        }

        public void Eat()
        {

        }
    }

    public class Robot : IWorker
    {
        public void Work()
        {

        }

        public void Eat()
        {
            throw new Exception("Robot's dont eat");
        }
    }
    // Here robots needed to implement Eat() method which they don't need
}

// Solution to above problem by segregating interfaces
namespace Good_Way
{
    public interface IWorker
    {
        public void Work();
    }

    public interface IHumanWorker : IWorker
    {
        public void Eat();
    }

    public interface IMachineWorker : IWorker
    {
        public void BatteryCharge();
    }

    public class HumanWorker : IHumanWorker
    {
        public void Work()
        {

        }

        public void Eat()
        {

        }
    }

    public class Robot : IMachineWorker
    {
        public void Work()
        {

        }

        public void BatteryCharge()
        {

        }
    }
}