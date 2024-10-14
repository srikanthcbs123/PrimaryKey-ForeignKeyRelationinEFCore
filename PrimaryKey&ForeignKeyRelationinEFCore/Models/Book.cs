using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PrimaryKey_ForeignKeyRelationinEFCore.Models
{
    public class Book
    {
        [Key] // Primary Key
        public int BookId { get; set; }
        public string Title { get; set; }

        // Foreign Key
        public int AuthorId { get; set; }

        // Navigation property
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }

    }
}
