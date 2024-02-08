using System.ComponentModel.DataAnnotations.Schema;

namespace RestAPIcurso.Model
{
    [Table("users")]
    public class Person
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("firstname")]
        public string? FirstName { get; set; }

        [Column("lastname")]
        public string? LastName { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("gender")]
        public string? Gender { get; set; }
    }
}
