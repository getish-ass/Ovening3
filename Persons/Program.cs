using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {

            
            PersonHandler personHandler = new PersonHandler();
            personHandler.CreatePerson(5, "Ge", "Assefa", 1.73, 80);
            //try
            //{
            //    personHandler.CreatePerson(5, "Getahun", "Ass", 1.73, 80);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            personHandler.ShowPerson();
            //Person person = new();
            //personHandler.SetAge(person, 45);
            //person.Weight = 45;
            //Console.WriteLine(person.Age + " " + person.Weight);

           
        }
    }
}
