using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEARApi.Models.ViewModels
{
    public class CustomerViewModel
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool CustomerStatus { get; set; }
    }
}
