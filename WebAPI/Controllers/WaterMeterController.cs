﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BL.Services;
using BL.Services.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class WaterMeterController : ControllerBase
    {
        IWaterMeterService _waterMeterService;
        public WaterMeterController(IWaterMeterService waterMeterService)
        {
            _waterMeterService = waterMeterService;
        }

        [HttpPost]
        [Route("wMeter")]
        public bool PostWaterMeter([FromBody] CreateWaterMeterDTO waterMeter)
        {
            return _waterMeterService.CreateWaterMeter(waterMeter);
        }


        [HttpPut]
        [Route("wMeter/inputDataID")]
        public bool PutDataWaterMeterId([FromBody] InputDataWaterMeterIdDTO waterMeter)
        {
            return _waterMeterService.InputDataWaterMeterId(waterMeter);
        }

        [Route("wMeter/inputDataSerNum")]
        public bool PutDataWaterMeterSerialNum([FromBody] InputDataWaterMeterSerialNumDTO waterMeter)
        {
            return _waterMeterService.InputDataWaterMeterSerialNum(waterMeter);
        }

        [Route("wMeter/reg")]
        public bool PutRegWaterMeter([FromBody]RegWaterMeterDTO waterMeter)
        {
            return _waterMeterService.RegWaterMeter(waterMeter);
        }
        
    }
}
