using System;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting PizzaStore app");
            Store s = new Store();
            s.Start();
        }
    }
}
