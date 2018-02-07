using System.Collections.Generic;
using MovieBox.Models;

namespace MovieBox.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }

<<<<<<< HEAD
        public string Title {
            get {
=======
        public string Title
        {
            get
            {
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
                if (Movie != null && Movie.Id != 0)
                    return "Edit Movie";

                return "New Movie";
            }
        }
    }
}