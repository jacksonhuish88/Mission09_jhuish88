using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_jhuish88.Models
{
    public class Order
    {
        [Key]
        [BindNever]
        public int OrderId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name:")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter an address:")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please enter a city:")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state:")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a zipcode:")]
        public string Zipcode { get; set; }

        [Required(ErrorMessage = "Please enter a country:")]
        public string Country { get; set; }

        public bool Anonymous { get; set; }
    }
}
