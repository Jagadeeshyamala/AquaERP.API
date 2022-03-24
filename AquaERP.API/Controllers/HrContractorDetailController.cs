using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AquaERP.Model.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using AquaERP.API.AquaERP.Services.AquaInterface;
using AquaERP.API.AquaERP.Services.AquaBusiness;


namespace AquaERP.API.Controllers
{
    [Route("api/HrContractorDetail")]
    [ApiController]
    public class HrContractorDetailController : ControllerBase
    {
        IHrContractorDetailBusiness objContractorDetail = new HrContractorDetailBusiness();

        [Route("GetHrContractorDetails")]
        public IEnumerable<HrContractorDetail> GetHrContractorDetails()
        {
            IEnumerable <HrContractorDetail> lstContractorDetails = new List<HrContractorDetail>();

            try
            {
                lstContractorDetails = objContractorDetail.GetHrContractorDetail();
            }
            catch (System.ApplicationException ex)
            {

                //throw new HttpResponseException;
            }
            catch (System.Exception)
            {

                throw;
            }
            return lstContractorDetails;
        }
    }
}
