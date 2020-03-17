using System;

namespace Lab1POO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person persona1 = new Person("Matias", "Rojas");
            Person persona2 = new Person("Persona", "X");

            Console.WriteLine("Parte 1");
            Console.WriteLine($"{persona1.Name} {persona1.SurName} hace {persona1.Lanzar()}");
            Console.WriteLine($"{persona2.Name} {persona2.SurName} hace {persona2.Lanzar()}");
            Console.WriteLine("");

            Console.WriteLine("Parte 2");
            Person pers = new Person("Bob", "Kunga");
            Console.WriteLine(pers.Name +" "+ pers.SurName);
            Console.ReadKey();
        }
    }
}
