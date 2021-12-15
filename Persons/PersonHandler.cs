using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class PersonHandler
    {

        //public Person person = new Person();
        public List<Person> persons = new List<Person>();
        
        public void SetAge(Person pers, uint age)
        {
            pers.Age = age;
        }
        public Person CreatePerson(uint age, string fname, string lname, double height, double weight)
        {
            Person person = new Person(); 

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

            persons.Add(person);

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
        public void PrintAllPersons()
        {
            foreach (var person in persons)
            {
                person.PrintInfo();
            }
        }
    }
}
