using System.ComponentModel.DataAnnotations;

namespace PrimaryKey_ForeignKeyRelationinEFCore.Models
{
    public class Author
    {
        [Key] // Primary Key
        public int AuthorId { get; set; }
        public string Name { get; set; }

        // Navigation property
        public List<Book> Books { get; set; } = new();

    }
}
