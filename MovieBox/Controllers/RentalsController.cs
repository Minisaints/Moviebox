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
<<<<<<< HEAD

=======
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
            return View("List");
        }
    }
}