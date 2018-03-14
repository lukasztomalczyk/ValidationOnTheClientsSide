using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationClientSite.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(25, ErrorMessage = "the name can not exceed 25 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        [Display(Name = "Surname")]
        [StringLength(25, ErrorMessage = "the surname can not exceed 25 characters")]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Not a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [Display(Name = "PhoneNumber")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Entered phone format is not valid.")]
        public string NumberPhone { get; set; }
    }
}