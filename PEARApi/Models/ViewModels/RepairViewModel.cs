using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PEARApi.Models.ViewModels
{
    public class RepairViewModel
    {
        public int RepairID { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public int DeviceID { get; set; }
        
        public DateTime RequestDate { get; set; }
        [Required(ErrorMessage ="No problem description supplied.")]
        public string ProblemDescription { get; set; }
        public int StatusID { get; set; }
        public bool Cancelled { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
