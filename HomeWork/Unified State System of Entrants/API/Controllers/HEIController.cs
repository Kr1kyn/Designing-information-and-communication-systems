using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Unified_State_System_of_Entrants.BLL.DTO;
using Unified_State_System_of_Entrants.BLL.Services;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HEIController : ControllerBase
    {
        private readonly ServiceHEI _serviceHEI;
        private readonly ServiceRankedListApplicants _serviceRankedListApplicants;
        public HEIController(ServiceHEI serviceHEI, ServiceRankedListApplicants serviceRankedListApplicants)
        {
            _serviceHEI = serviceHEI;
            _serviceRankedListApplicants = serviceRankedListApplicants;
        }

        [HttpPost]
        [Route("AddHEI")]
        public void AddNewHEI(HEI_DTO hEI_DTO)
        {
            _serviceHEI.CreateHEI(hEI_DTO);
        }
        [HttpGet]
        [Route("GetReport")]
        public JsonResult CreateReport(int HEI_Id)
        {
            return _serviceRankedListApplicants.CreateReport(HEI_Id);
        }

        [HttpPost]
        [Route("AddRankedList")]
        public void AddRankedList(RankedList_DTO rankedList_DTO)
        {
            _serviceRankedListApplicants.AddRankedList(rankedList_DTO);
        }
    }
}
