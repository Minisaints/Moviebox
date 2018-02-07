using System.Collections.Generic;

namespace MovieBox.Dtos
{
    public class RentalDto
    {

        public List<int> MovieIds { get; set; }
        public int CustomerId { get; set; }

        public bool BeenReturned { get; set; }

    }
}