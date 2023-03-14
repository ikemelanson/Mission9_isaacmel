using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_isaacmel.Models
{

    //Model for to store user information
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage ="Please enter a Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an Address")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        [Required(ErrorMessage ="Please Enter City Name")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please Enter State Name")]
        public string State { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please Enter Country Name")]
        public string Country { get; set; }


    }

}
