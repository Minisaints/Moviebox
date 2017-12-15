using MovieBox.Models;
using System.Web.Mvc;

namespace MovieBox.Controllers
{
    public class RentalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: RentalForm
        public ActionResult New()
        {
            return View("RentalForm");
        }

        public ActionResult Index()
        {

            return View("List");
        }
    }
}