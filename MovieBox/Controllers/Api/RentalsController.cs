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
    //[Authorize(Roles = RoleName.IsAdministrator)]
    public class RentalsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        // Constructor
        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/rentals
        // Removed AutoMapper
        public IHttpActionResult GetRentals()
        {

            var rental = _context.Rentals
                .Where(c => c.Id != 0)
                .Include(c => c.Customer).Select(x => new
                {
                    x.Id,
                    MovieId = x.Movie.Id,
                    CustomerId = x.Customer.Id,
                    CustomerName = x.Customer.Name,
                    MovieName = x.Movie.Name,
                    x.DateRented,
                    x.DateReturned,
                    x.BeenReturned
                });

            return Ok(rental);

        }

        // GET /api/rentals/1
        // Removed AutoMapper
        public IHttpActionResult GetRental(int id)
        {
            var rentalId = _context.Rentals.SingleOrDefault(c => c.Id == id);

            if (rentalId == null)
                return NotFound();

            var rental = _context.Rentals
                .Where(c => c.Id == id)
                .Include(c => c.Customer).Select(x => new
                {
                    x.Id,
                    MovieId = x.MovieId,
                    CustomerId = x.CustomerId,
                    CustomerName = x.Customer.Name,
                    MovieName = x.Movie.Name,
                    x.DateRented,
                    x.DateReturned,
                    x.BeenReturned
                });

            return Ok(rental);
        }

        // POST /api/rentals
        // Removed AutoMapper 
        [HttpPost]
        public IHttpActionResult CreateRental(RentalDto newRental)
        {
            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.AvailableAmount == 0)
                    return BadRequest("Movie is not available.");

                movie.AvailableAmount--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now,
                    MovieId = movie.Id,
                    CustomerId = customer.Id,
                    BeenReturned = newRental.BeenReturned
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();

        }

        // PUT /api/rentals/1
        // Using AutoMapper
        [HttpPut]
        public IHttpActionResult UpdateRental(int id, RentalUpdateDto rentalUpdateDto)
        {

            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var rentalInDb = _context.Rentals.Where(c => c.Id == id).SingleOrDefault(c => c.Id == id);

            if (rentalInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            //// check for changes
            //var changes = _context.ChangeTracker.HasChanges();

            Mapper.Map(rentalUpdateDto, rentalInDb);

            _context.SaveChanges();

            return Ok(rentalInDb);
        }

        // DELETE /api/rentals/1
        [Authorize(Roles = RoleName.IsAdministrator)]
        public void DeleteRental(int id)
        {
            var rentalInDb = _context.Rentals.SingleOrDefault(c => c.Id == id);

            if (rentalInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Rentals.Remove(rentalInDb);
            _context.SaveChanges();
        }
    }
}
