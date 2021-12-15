using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {

            
            PersonHandler personHandler = new PersonHandler();
            personHandler.CreatePerson(5, "Gedfgsfe", "Assefa", 1.73, 80);
            personHandler.CreatePerson(50, "Gadgfh", "Cfdghdgf", 1.73, 80);
            personHandler.CreatePerson(34, "Godfghdgf", "Adgfhdf", 1.73, 80);
            personHandler.CreatePerson(87, "Gifdghdgf", "Bdfghfd", 1.73, 80);
            //try
            //{
            //    personHandler.CreatePerson(5, "Getahun", "Ass", 1.73, 80);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            personHandler.PrintAllPersons();

            //Person person = new();
            //personHandler.SetAge(person, 45);
            //person.Weight = 45;
            //Console.WriteLine(person.Age + " " + person.Weight);

            //Manager(PersonHandler(Person))
           
        }
    }
}
