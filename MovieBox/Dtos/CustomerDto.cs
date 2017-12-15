using System;
using System.ComponentModel.DataAnnotations;

namespace MovieBox.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }

        //[Min18Years]
        public DateTime? BirthDate { get; set; }
    }
}