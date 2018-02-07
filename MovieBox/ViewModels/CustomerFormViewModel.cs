using System.Collections.Generic;
using MovieBox.Models;

namespace MovieBox.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipType { get; set; }
        public Customer Customer { get; set; }

<<<<<<< HEAD
        public string Title {
            get {
=======
        public string Title
        {
            get
            {
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
                if (Customer != null && Customer.Id != 0)
                    return "Edit Customer";

                return "New Customer";
            }
        }
    }
}