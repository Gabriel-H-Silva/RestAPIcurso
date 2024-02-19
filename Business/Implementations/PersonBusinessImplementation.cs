using RestAPIcurso.Data.Converter.Implementations;
using RestAPIcurso.Data.DM;
using RestAPIcurso.Model;
using RestAPIcurso.Repository;

namespace RestAPIcurso.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;

        private readonly PersonConverter _converter;
        public PersonBusinessImplementation(IRepository<Person> repository) 
        {
            _repository = repository;
            _converter = new PersonConverter();
        }
        public List<PersonDM> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public PersonDM FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public PersonDM Create(PersonDM person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public PersonDM Update(PersonDM person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
