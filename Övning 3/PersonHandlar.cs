using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3
{
    class PersonHandlar
    {

        public void SetAge(Person pers, int age)

        {
            pers.Age = age;
        }
        public Person CreatePerson(int age, string fname, string lname, int height, int weight)
        {
            Person person = new Person();
            person.FName = fname;
            person.LName = lname;
            person.Height = height;
            person.Weight = weight;

            SetAge(person, age);

            return person;


        }
        public void SetFName(Person pers, string fname)
        {
            pers.FName = fname;
        }
        public void SetLName(Person pers, string lname)
        {
            pers.LName = lname;
        }
        public void Height(Person pers, int height)
        {
            pers.Height = height;
        }
        public void Weight(Person pers, int weight)
        {
            pers.Weight = weight;

        }
    }
}
