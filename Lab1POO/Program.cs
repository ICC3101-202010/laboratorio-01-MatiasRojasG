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
            Console.WriteLine($"{persona1.GetName()} {persona1.GetSurName()} hace {persona1.Lanzar()}");
            Console.WriteLine($"{persona2.GetName()} {persona2.GetSurName()} hace {persona2.Lanzar()}");
            Console.WriteLine("");

            Console.WriteLine("Parte 2");
            Person pers = new Person();
            Console.WriteLine(pers.GetName() +" "+ pers.GetSurName());
            Console.ReadKey();
        }
    }
}
