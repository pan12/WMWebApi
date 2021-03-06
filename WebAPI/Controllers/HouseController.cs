﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL.Models;
using BL.Services;
using BL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        IHouseService _houseService;
        public HouseController(IHouseService houseService)
        {
            _houseService = houseService;
        }

        
        [HttpGet]
        [Route("houses")]
        public Task<IEnumerable<ReturnHouseDTO>> GetHouses()
        {
            return _houseService.GetHouses();
        }

        [Route("house/consumptionMax")]
        public Task<ReturnHouseDTO>
            GetConsumptionMax()
        {
            return _houseService.GetHouseConsumptionMax();
        }

        [Route("house/consumptionMin")]
        public Task<ReturnHouseDTO> GetConsumptionMin()
        {
            return _houseService.GetHouseConsumptionMin();
        }

        [Route("house/{id}")]
        public ReturnHouseDTO GetHouse(int id)
        {
            GetHouseInfoDTO infoDTO = new GetHouseInfoDTO { Id = id };
            return _houseService.GetHouse(infoDTO);
        }

        [Route("house/{id}/meters")]
        public IEnumerable<ReturnWaterMeterDTO> GetAllWaterMeters(int id)
        {
            GetHouseInfoDTO infoDTO = new GetHouseInfoDTO { Id = id };
            return _houseService.GetAllWaterMeters(infoDTO);
        }

        // POST: api/House
        [HttpPost]
        [Route("house")]
        public bool PostHouse ([FromBody] CreateHouseDTO houseDTO)
        {
            return _houseService.CreateHouse(houseDTO);
        }

        // PUT: api/House/5
        [HttpPut]
        [Route("house")]
        public bool PutHouse([FromBody] EditHouseDTO houseDTO)
        {
            return _houseService.EditHouse(houseDTO);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        [Route("house/{id}")]
        public bool DeleteHouse (int id)
        {
            RemoveHouseDTO remove = new RemoveHouseDTO { Id = id };
            return _houseService.RemoveHouse(remove);
        }
    }
}
