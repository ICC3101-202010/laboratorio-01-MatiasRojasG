using System;

namespace Lab1POO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person persona1 = new Person();
            persona1.Name = "Matias";
            persona1.LastName = "Rojas";
            Person persona2 = new Person();
            persona2.Name = "Bob";
            persona2.LastName = "Kunga";
            


            Console.WriteLine($"{persona1.Name} {persona1.LastName} hace {persona1.Lanzar()}");
            Console.WriteLine($"{persona2.Name} {persona2.LastName} hace {persona2.Lanzar()}");
            Console.ReadKey();
        }
    }
}
