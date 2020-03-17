using System;
namespace Lab1POO
{
    public class Person
    {
        public string Name;
        public string LastName;

        public int Lanzar()
        {
            Random rdm = new Random();
            return rdm.Next(0, 3);

        }

    }
}
