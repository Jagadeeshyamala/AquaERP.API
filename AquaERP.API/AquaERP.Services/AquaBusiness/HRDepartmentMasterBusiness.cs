using AquaERP.API.AquaERP.Services.AquaInterface;
using AquaERP.API.Repository;
using AquaERP.Model.Models;
using System;
using System.Collections.Generic;

namespace AquaERP.API.AquaERP.Services.AquaBusiness
{
    public class HRDepartmentMasterBusiness : IHRDepartmentMasterBusiness
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        public void DeleteHrDepartmentMaster(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HrDepartmentMaster> GetHrDepartmentMaster()
        {
            return unitOfWork.HrDepartmentMasterRepository.GetAll();
        }

        public HrDepartmentMaster InsertHrDepartmentMaster(HrDepartmentMaster input)
        {
            throw new NotImplementedException();
        }

        public HrDepartmentMaster UpdateHrDepartmentMaster(HrDepartmentMaster input)
        {
            throw new NotImplementedException();
        }
    }
}
