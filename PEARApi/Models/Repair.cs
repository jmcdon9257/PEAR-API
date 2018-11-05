using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PEARApi.Models
{
    public class Repair
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RepairID { get; set; }
        public int CustomerID { get; set; }
        public int DeviceID { get; set; }
        public DateTime RequestDate { get; set; }
        public string ProblemDescription { get; set; }
        public int StatusID { get; set; }
        public bool Cancelled { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Device Device { get; set; }
        public virtual RepairStatus RepairStatus { get; set; }
    }
}
