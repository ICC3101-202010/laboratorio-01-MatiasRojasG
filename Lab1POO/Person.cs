using System;
namespace Lab1POO
{
    public class Person
    {
        public string Name;
        public string SurName;
        /*Constructor*/
        public Person(string Name, string SurName)
        {
            this.Name = Name;
            this.SurName = SurName;
        }
        /*Method Lanzar */
        public int Lanzar()
        {
            Random rdm = new Random();
            return rdm.Next(0, 3);

        }

    }
}
