using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAuthentication_V2.Models
{
    public class Contact
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage =
    "The {0} must be minumum length of 3 characters. Maximum of 60 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100")]
        public int Age { get; set; }

        [StringLength(20)]
        [RegularExpression(@"^[0-9\s]+$", ErrorMessage = "Only numbers allowed")]
        public string Phone { get; set; }

        [StringLength(40)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Enter a Valid Email Address")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Birthday { get; set; }


    }
    public class ContactDBContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}