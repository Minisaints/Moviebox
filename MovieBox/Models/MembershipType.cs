using System.ComponentModel.DataAnnotations;

namespace MovieBox.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }
<<<<<<< HEAD
=======

>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
        public static readonly byte MinimumAgeForContract = 18;
<<<<<<< HEAD

=======
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
    }
}