﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OilStationCoreAPI.IServices;
using OilStationCoreAPI.ViewModels;

namespace OilStationCoreAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LeaveController : ControllerBase
    {
        private readonly ILeaveServices _leaveServices;

        public LeaveController(ILeaveServices leaveServices)
        {
            this._leaveServices = leaveServices;
        }

        [HttpGet]
        [Authorize(Policy = "Leave_Get")]
        public ResponseModel<List<LeaveViewModel>> Leave_Get()
        {
            return _leaveServices.Leave_Get();
        }

        [HttpGet]
        [Authorize(Policy = "Leave_CheckGet")]
        public ResponseModel<List<LeaveViewModel>> Leave_CheckGet()
        {
            return _leaveServices.Leave_CheckGet();
        }

        [HttpPost]
        [Authorize(Policy = "Leave_Add")]
        public ResponseModel<bool> Leave_Add([FromBody]LeaveViewModel model)
        {
            return _leaveServices.Leave_Add(model);
        }

        [HttpPost]
        [Authorize(Policy = "Leave_Check")]
        public ResponseModel<bool> Leave_Check([FromBody]CheckViewModel model)
        {
            return _leaveServices.Leave_Check(model);
        }

        [HttpPost]
        [Authorize(Policy = "Leave_Delete")]
        public ResponseModel<bool> Leave_Delete(string id)
        {
            return _leaveServices.Leave_Delete(id);
        }
    }
}