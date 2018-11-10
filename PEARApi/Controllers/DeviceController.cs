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
    [Route("api/device")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly DeviceService _deviceService;
        private readonly IMapper _mapper;

        public DeviceController(DeviceService deviceService,IMapper mapper)
        {
            _mapper = mapper;
            _deviceService = deviceService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DeviceViewModel>> GetDeviceAsync(int? id)
        {
            if(!id.HasValue)
            {
                return BadRequest("No DeviceID supplied");
            }

            var device = await _deviceService.GetDeviceByIDAsync(id.Value);

            if(device == null)
            {
                return BadRequest(string.Format("No Device found for ID {0}", id.Value));
            }

            return _mapper.Map<DeviceViewModel>(device);
        }

        [HttpPost]
        public async Task<ActionResult<DeviceViewModel>> AddDevice([FromBody] DeviceViewModel deviceViewModel)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Device device = new Device
            {
                DeviceTypeID = deviceViewModel.DeviceTypeID,
                SerialNumber = deviceViewModel.SerialNumber,
                Model = deviceViewModel.Model,
                CreatedDate = DateTime.Now
            };

            var result = await _deviceService.AddDeviceAsync(device);
            
                return _mapper.Map<DeviceViewModel>(device);
            
           
        }
    }
}