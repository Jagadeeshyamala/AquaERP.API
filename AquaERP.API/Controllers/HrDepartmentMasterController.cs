using AquaERP.API.AquaERP.Services.AquaBusiness;
using AquaERP.API.AquaERP.Services.AquaInterface;
using AquaERP.Model.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AquaERP.API.Controllers
{
    [Route("api/HrDepartmentMaster")]
    [ApiController]
    public class HrDepartmentMasterController : ControllerBase
    {
         IHRDepartmentMasterBusiness objHrDepartmentMaster = new HRDepartmentMasterBusiness();

        [HttpGet]
        [Route("GetHrDepartmentMaster")]
        public IEnumerable<HrDepartmentMaster> GetHrContractorDetails()
        {
            IEnumerable<HrDepartmentMaster> lstHrDepartmentMaster = new List<HrDepartmentMaster>();

            try
            {
                lstHrDepartmentMaster = objHrDepartmentMaster.GetHrDepartmentMaster();
            }
            catch (System.ApplicationException)
            {

                throw;
            }
            catch (System.Exception)
            {

                throw;
            }
            return lstHrDepartmentMaster;
        }
    }
}
