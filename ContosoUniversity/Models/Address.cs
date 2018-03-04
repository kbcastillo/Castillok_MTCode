using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public abstract class Address
    {
        [EmailAddress]
        [RegularExpression("[a-zA-Z0-9._]+@contoso.edu$", ErrorMessage = "You must have a valid Contoso University Email.")]

        public string EmailAddress { get; set; }
    }
}