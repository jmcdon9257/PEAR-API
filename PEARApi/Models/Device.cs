using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PEARApi.Models
{
    public class Device
    {
        [Key]
        public int DeviceID { get; set; }
        public int DeviceTypeID { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public bool DeletedFlag { get; set; }

        public virtual List<Repair> Repair { get; set; }
    }
}
