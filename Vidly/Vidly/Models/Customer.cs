using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool isSubscribedToNewsletter { get; set; }
        [ForeignKey("MembershipTypeId")]
        public MembershipType MembershipType { get; set; }

        public byte MembershipTypeId { get; set; } //foreign key
    }
}