using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RestAPIcurso.Data.DM;
using System.Threading.Tasks;

namespace RestAPIcurso.Hypermedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutingContext response);
        Task Enrich(ResultExecutingContext response);
    }
}
