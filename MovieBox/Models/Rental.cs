using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieBox.Models
{
    public class Rental
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Movie Movie { get; set; }

        public int MovieId { get; set; }

        public Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }

        [Required]
        public bool BeenReturned { get; set; }
<<<<<<< HEAD



=======
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
    }
}