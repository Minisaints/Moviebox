using System;
using System.ComponentModel.DataAnnotations;

namespace MovieBox.Dtos
{
    public class MovieDto
    {
<<<<<<< HEAD

=======
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public GenreDto Genre { get; set; }

        public byte GenreId { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [Range(0, 20, ErrorMessage = "The field Number in Stock must be between 0 - 20.")]
        public byte Stock { get; set; }

        [Required]
        [Range(0, 20, ErrorMessage = "The field Number in Stock must be between 0 - 20.")]
        public byte? AvailableAmount { get; set; }
<<<<<<< HEAD

=======
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
    }
}