using System;

namespace ZbW.DesignPatterns.Mediator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var posSystem = new PoSSystem();
            var customerController = new CustomerController();

            var mediator = new ConcreteMediator(posSystem, customerController);

            posSystem.Buy(1, 1001);

            Console.ReadLine();
        }
    }
}
