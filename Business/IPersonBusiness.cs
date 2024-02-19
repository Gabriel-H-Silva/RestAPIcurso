using RestAPIcurso.Data.DM;
using RestAPIcurso.Model;

namespace RestAPIcurso.Business
{
    public interface IPersonBusiness
    {
        PersonDM Create(PersonDM person);
        PersonDM FindById(long id);
        List<PersonDM> FindAll();
        PersonDM Update(PersonDM person);
        void Delete(long id);
    }
}
