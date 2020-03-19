using System;
namespace Lab1POO
{
    public class Person
    {
        private string Name;
        private string SurName;

        /*Constructor*/
        public Person(string Name, string SurName)
        {
            this.Name = Name;
            this.SurName = SurName;
        }
        public Person()
        {
            Name = "Bob";
            SurName = "Kunga";
        }
        /*Method Lanzar */
        public int Lanzar()
        {
            Random rdm = new Random();
            return rdm.Next(0, 3);

        }
        //Method return public//
        public string GetName()
        {
            return Name;
        }
        public string GetSurName()
        {
            return SurName;
        }
    }
}
