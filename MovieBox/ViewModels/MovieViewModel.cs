using System.Collections.Generic;
using MovieBox.Models;

namespace MovieBox.ViewModels
{
    public class MovieViewModel
    {
        public List<Movie> Movie { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Genre> Genres { get; set; }
    }
}