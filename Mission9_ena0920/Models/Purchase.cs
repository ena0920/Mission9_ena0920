﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_ena0920.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name:")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Please enter a valid address:")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please enter a valid city:")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a valid zip:")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter a valid state:")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a valid country:")]
        public string Country { get; set; }




    }
}
