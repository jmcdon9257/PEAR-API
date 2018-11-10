using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PEARApi.Models.ViewModels
{
    public class DeviceViewModel
    {
        public int DeviceID { get; set; }
        [Required(ErrorMessage ="Device ID Required")]
        public int DeviceTypeID { get; set; }
        [Required(ErrorMessage ="Model is required")]
        public string Model { get; set; }
        [Required(ErrorMessage ="Serial Number is required")]
        public string SerialNumber { get; set; }

    }
}
