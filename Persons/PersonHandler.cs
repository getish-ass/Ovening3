using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class PersonHandler
    {

        public Person person = new Person();
        
        public void SetAge(Person pers, uint age)
        {
            pers.Age = age;
        }
        public Person CreatePerson(uint age, string fname, string lname, double height, double weight)
        {
            try { 
            person.Age = age;
            person.Fname = fname;
            person.Lname = lname;
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            

            person.Height = height;
            person.Weight = weight;
            return person;
        }
        //public List<Person> CreatePersonList(uint age, string fname, string lname, double height, double weight)
        //{
        //    Person persons = new();
        //    while( )
        //    try
        //    {
        //        persons.Age = age;
        //        persons.Fname = fname;
        //        persons.Lname = lname;
        //    }
        //    catch (ArgumentException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //
        //
        //    persons.Height = height;
        //    persons.Weight = weight;
        //   
        //}
        //
        //    ListPerson.add(persons);
        //    return ListPerson;
        //}
        public void ShowPerson()
        {
            Console.WriteLine("age: " + person.Age +
                              " First Name: " + person.Fname +
                              " Last Name: " + person.Lname +
                              " Height: " + person.Height +
                              " Weight: " + person.Weight );
        }
    }
}
