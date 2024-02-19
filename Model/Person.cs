using RestAPIcurso.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestAPIcurso.Model
{
    [Table("users")]
    public class Person : BaseEntity
    {
        [Column("name")]
        public string? name { get; set; }

        [Column("office")]
        public string? office { get; set; }

        [Column("password")]
        public string? password { get; set; }

    }
}
