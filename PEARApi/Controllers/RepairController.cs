using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PEARApi.Models;
using PEARApi.Models.ViewModels;
using PEARApi.Services;

namespace PEARApi.Controllers
{
    [Route("api/repair")]
    [ApiController]
    public class RepairController : ControllerBase
    {
        private readonly RepairService _repairService;
        private readonly IMapper _mapper;

        public RepairController(RepairService repairService,IMapper mapper)
        {
            _mapper = mapper;
            _repairService = repairService;
        }


        [HttpPost]
        public async Task<ActionResult<RepairViewModel>> NewRepairAsync([FromBody] RepairViewModel repairViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Repair repair = new Repair {
                CustomerID = repairViewModel.CustomerID,
                DeviceID = repairViewModel.DeviceID,
                ProblemDescription = repairViewModel.ProblemDescription,
                RequestDate = DateTime.Now,
                Cancelled = false,
                StatusID = 1//New request
            };
            
                var result = await _repairService.NewRepair(repair);
            return _mapper.Map<RepairViewModel>(repair);
           
           
        }
    }
}