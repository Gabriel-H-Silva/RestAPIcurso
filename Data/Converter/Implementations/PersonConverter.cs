using RestAPIcurso.Data.Converter.Contract;
using RestAPIcurso.Data.DM;
using RestAPIcurso.Model;

namespace RestAPIcurso.Data.Converter.Implementations
{
    public class PersonConverter : IParser<PersonDM, Person>, IParser<Person, PersonDM>
    {
        public Person Parse(PersonDM origin)
        {
            if (origin == null) return null;
            return new Person
            {
                Id = origin.Id,
                name = origin.name,
                office = origin.office,
                password = origin.password
            };
        }        

        public PersonDM Parse(Person origin)
        {
            if (origin == null) return null;
            return new PersonDM
            {
                Id = origin.Id,
                name = origin.name,
                office = origin.office,
                password = origin.password
            };
        }

        public List<Person> Parse(List<PersonDM> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<PersonDM> Parse(List<Person> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
