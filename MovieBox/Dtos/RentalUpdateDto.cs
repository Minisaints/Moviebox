using System;
using System.ComponentModel.DataAnnotations;

namespace MovieBox.Dtos
{
    public class RentalUpdateDto
    {

        public int Id { get; set; }

        public int? MovieId { get; set; }

        public int? CustomerId { get; set; }

        public MovieDto Movie { get; set; }

        public CustomerDto Customer { get; set; }

        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }

        [Required]
        public bool BeenReturned { get; set; }
    }
}