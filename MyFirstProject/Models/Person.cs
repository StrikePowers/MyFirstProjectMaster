using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string n)
        {
            Name = n;
        }

        public static List<Person> GETNAME()
        {
            return new List<Person>
            {
                new Person("Chris Pratt"),
                new Person("25"),
                new Person("VD")
            };
        }
    }
}
