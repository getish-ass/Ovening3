using System;
using System.Linq;

namespace Persons
{
    internal class Person
    {
        private uint age;
        private string fname;
        private string lname;
        private double height;
        private double weight;
        

        public uint Age 
        { get { return age; }
            set {
                if (value > 0 ) age = value;
                else
                    throw new ArgumentException("Age can not be zero");  }
        }
        public string Fname
        { get { return fname; }
            set
            {
                int x = value.Length;

                if (x > 2 && x < 10) lname = value;
                else
                    throw new ArgumentException("First Name must be more than 2 and less than 10 character");

            }
        }
        public string Lname
        {
            get { return lname; }
            set
            {
                int x = value.Length;

                if (x > 3 && x < 15) fname = value;
                else
                    throw new ArgumentException("Last Name must be more than 3 and less than 15 character");

            }
        }
        public double Height {  get{ return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight= value; } }
        

        public Person()
        {
            age = 1;
        }
        public Person(string fname1) : this()
        {
            fname = fname1;
        }
        

        public void ListPerson()
        {
            Console.WriteLine(age + " " + fname + " " + lname);
        }

    }
}