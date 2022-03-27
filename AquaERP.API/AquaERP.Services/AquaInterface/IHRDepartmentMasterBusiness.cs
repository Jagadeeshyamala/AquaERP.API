using AquaERP.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AquaERP.API.AquaERP.Services.AquaInterface
{
    public interface IHRDepartmentMasterBusiness
    {
        IEnumerable<HrDepartmentMaster> GetHrDepartmentMaster();
        HrDepartmentMaster InsertHrDepartmentMaster(HrDepartmentMaster input);
        HrDepartmentMaster UpdateHrDepartmentMaster(HrDepartmentMaster input);
        void DeleteHrDepartmentMaster(Guid id);
    }
}
