using System;
using System.ComponentModel.DataAnnotations;

namespace MovieBox.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Required]
        [Range(0, 20, ErrorMessage = "The Number in Stock must be between 0 - 20.")]
        public byte Stock { get; set; }

        [Range(0, 20, ErrorMessage = "The Available Amount must be between 0 - 20.")]
        public byte? AvailableAmount { get; set; }
<<<<<<< HEAD

=======
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
    }
}