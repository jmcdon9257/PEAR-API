using PEARApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEARApi.Services
{
    public class RepairService
    {
        private readonly PearDbContext _pearDbConext;

        public RepairService(PearDbContext pearDbContext)
        {
            _pearDbConext = pearDbContext;
        }

        public async Task<Repair> NewRepair(Repair repair)
        {
            _pearDbConext.Repair.Add(repair);
            var result = await _pearDbConext.SaveChangesAsync();

            return repair;
        }
    }
}
