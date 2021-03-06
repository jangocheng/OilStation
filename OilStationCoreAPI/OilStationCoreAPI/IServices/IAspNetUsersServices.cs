﻿using OilStationCoreAPI.Models;
using OilStationCoreAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OilStationCoreAPI.IServices
{
    public interface IAspNetUsersServices
    {
        ResponseModel<IEnumerable<UserAndRoleViewModel>> UserRole_Get();

        ResponseModel<bool> UserInfo_Update(UserInfoViewModel model);

        ResponseModel<bool> UserInfo_Delete(string id);
    }
}
