using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PEARApi.Models.ViewModels
{
    public class CustomerViewModel
    {
        public int CustomerID { get; set; }
        [Required(ErrorMessage ="First name required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name required")]
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool CustomerStatus { get; set; }
    }
}
