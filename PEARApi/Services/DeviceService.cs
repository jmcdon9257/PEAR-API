using PEARApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEARApi.Services
{
    public class DeviceService
    {
        private PearDbContext _pearDbContext;
      

        public DeviceService(PearDbContext pearDbContext)
        {
           
            _pearDbContext = pearDbContext;
        }

        public async Task<Device> AddDeviceAsync(Device device)
        {
            _pearDbContext.Device.Add(device);

            var result = await _pearDbContext.SaveChangesAsync();

            return device;
        }

        public async Task<Device> GetDeviceByIDAsync(int deviceID)
        {
            var device = await _pearDbContext.Device.FindAsync(deviceID);
            return device;
        }
    }
}
