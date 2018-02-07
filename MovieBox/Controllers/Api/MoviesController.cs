using AutoMapper;
using MovieBox.Dtos;
using MovieBox.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace MovieBox.Controllers.Api
{
<<<<<<< HEAD

=======
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
    public class MoviesController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/movies
        // Using AutoMapper
        public IHttpActionResult GetMovies(string query = null)
        {
<<<<<<< HEAD

=======
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
            var moviesQuery = _context.Movies
                .Include(c => c.Genre)
                .Where(c => c.AvailableAmount > 0);

            if (!string.IsNullOrWhiteSpace(query))
                moviesQuery = moviesQuery.Where(c => c.Name.Contains(query));

            var movieDtos = moviesQuery.ToList().Select(Mapper.Map<Movie, MovieDto>);


            return Ok(movieDtos);
        }

        // GET /api/movies/1
        // Using AutoMapper
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return NotFound();

            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }

        // POST /api/movies
        // Using AutoMapper
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }

        // PUT /api/movies/1
        // Using AutoMapper
        [HttpPut]
        [Authorize(Roles = RoleName.IsAdministrator)]
        public void UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(movieDto, movieInDb);

            _context.SaveChanges();
        }

        // DELETE /api/movies/1
        [HttpDelete]
        [Authorize(Roles = RoleName.IsAdministrator)]
        public void DeleteMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();
        }
<<<<<<< HEAD

    }
}
=======
    }
}
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
