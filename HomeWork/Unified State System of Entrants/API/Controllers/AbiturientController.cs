using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Unified_State_System_of_Entrants.BLL.Services;
using Unified_State_System_of_Entrants.BLL.DTO;
using Unified_State_System_of_Entrants.BLL.Filters;
using Unified_State_System_of_Entrants.BLL.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AbiturientController : ControllerBase
    {
        private readonly ServiceEntrant _serviceEntrant;
        private readonly ServiceUser _serviceUser;
        private readonly ServiceHEI _serviceHEI;
        private readonly ServiceRankedListApplicants _serviceRankedListApplicants;

        public AbiturientController(ServiceUser serviceUser, ServiceEntrant serviceEntrant, ServiceHEI serviceHEI, ServiceRankedListApplicants serviceRankedListApplicants)
        {
            _serviceEntrant = serviceEntrant;
            _serviceUser = serviceUser;
            _serviceHEI = serviceHEI;
            _serviceRankedListApplicants = serviceRankedListApplicants;
        }
        [Route("Apply")]
        //[HttpGet("{userId} {HEI_Id}")]
        [HttpGet]
        public string ApplyToHEI(int userId, int HEI_Id)
        {
            return _serviceEntrant.CreateApplication(userId, HEI_Id);
            /*var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();*/
        }

        [HttpPost]
        [Route("NewUser")]
        public void AddNewUser([FromBody] User_DTO user_DTO)
        {
            _serviceUser.CreateUser(user_DTO);
        }

        [HttpPost]
        [Route("SetProfile")]
        public void SetProfile([FromBody] Entrant_DTO entrant_DTO)
        {
            _serviceEntrant.CreateEntrant(entrant_DTO);
        }

        [HttpGet]
        //[HttpGet("{HEI_Id}")]
        [Route("HEIProfiles")]
        public HEI_DTO GetHEIProfile(int HEI_Id)
        {
            return _serviceHEI.GetHEIProfile(HEI_Id);
        }
        [HttpPost]
        [Route("FilterHEI")]
        public ICollection<HEI_DTO> FilterHEIs([FromBody] FilterInfo filterInfo)
        {
            return _serviceHEI.FilterWithParameters(filterInfo);
        }
        [HttpGet]
        [Route("RankedList")]
        public RankedList_DTO GetRankedList(int HEI_Id)
        {
            return _serviceRankedListApplicants.GetRankedList(HEI_Id);
        }
/*
        {
  "heI_Id": 1,
  "tankedList": [
    {
      "name": "KOnstantin",
      "position": 1
    },
    {
      "name": "Anna",
      "position": 2
    },
    {
    "name": "Svetlana",
      "position": 3
    }
  ]
}
*/
        /*
         {
  "id": 1,
  "name": "ITMO",
  "description": "IT's More that a University",
  "location": [
    "Санкт-Петербург"
  ],
  "tagsForFilter": [
    "IT", "Большой", "Оптика", "Физика", "Химия"
  ],
  "informationLinks": [
    "InformationLinks"
  ]
}
          */
    }
}
