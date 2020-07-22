using System;
using System.Collections.Generic;
using System.Threading;
using RestwithAspNetUdemy.Model;

namespace RestwithAspNetUdemy.Services.Implementattions
{
    public class PersonServiceImpl : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long Id)
        {
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Julio "  + i,
                LastName = "Maure " + i,
                Address = "Rua falano de tal " + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindById(long Id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Julio",
                LastName = "Maure",
                Address = "Rua falano de tal",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
