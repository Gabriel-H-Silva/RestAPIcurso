using RestAPIcurso.Model;

namespace RestAPIcurso.Services.Implementations
{
    public class PersonServiceImplementation : IPersonServices
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {

        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MorkPerson(i);
                persons.Add(person);
            };
            return persons;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Test",
                LastName = "Test",
                Email = "teste@gmail.com",
                Gender = "Male",
                Name = "Teste"
            };
        }

        public Person Update(Person person)
        {

            return person;
        }
        private Person MorkPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person FistName" + i,
                LastName = "Person LastName" + i,
                Email = "Email@gmail.com" + i,
                Gender = "gender" + i,
                Name = "Name" + i
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
