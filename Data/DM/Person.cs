using RestAPIcurso.Hypermedia;
using RestAPIcurso.Hypermedia.Abstract;
using RestAPIcurso.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestAPIcurso.Data.DM
{
    public class PersonDM : ISupportHyperMedia
    {
        public long Id { get; set; }
        public string? name { get; set; }
        public string? office { get; set; }
        public string? password { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
