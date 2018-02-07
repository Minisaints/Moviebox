using MovieBox.Models;
using MovieBox.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MovieBox.Controllers
{
<<<<<<< HEAD

    public class CustomersController : Controller
    {

=======
    public class CustomersController : Controller
    {
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
        private readonly ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
<<<<<<< HEAD

=======
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
            //if (MemoryCache.Default["Genres"] == null)
            //{
            //    MemoryCache.Default["Genres"] = _context.Genres.ToList();
            //}

            //var genres = MemoryCache.Default["Genres"] as IEnumerable<Genre>;

            if (User.IsInRole(RoleName.IsAdministrator))
                return View("List");


<<<<<<< HEAD

            return View("ReadOnlyList");

=======
            return View("ReadOnlyList");
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
        }

        //[Route("Customers/Details/{id}")]

        public ActionResult Details(int id)
        {
<<<<<<< HEAD

=======
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
            var customer = _context.Customers
                .Include(b => b.MembershipType)
                .SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();

            var viewModel = new CustomerFormViewModel()
            {
                Customer = new Customer(),
                MembershipType = membershipTypes
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
<<<<<<< HEAD

=======
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel()
                {
                    Customer = customer,
                    MembershipType = _context.MembershipTypes.ToList()
                };

                return View("CustomerForm", viewModel);
            }

            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);

                customerInDb.Name = customer.Name;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }
<<<<<<< HEAD
=======

>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
        [Authorize(Roles = RoleName.IsAdministrator)]
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(m => m.Id == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel()
            {
                Customer = customer,
                MembershipType = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }
    }
}