using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unified_State_System_of_Entrants.BLL.DTO;
using Unified_State_System_of_Entrants.BLL.Reports;
using Unified_State_System_of_Entrants.DAL.Interfaces;
using Unified_State_System_of_Entrants.DAL.Models;

namespace Unified_State_System_of_Entrants.BLL.Services
{
    public class ServiceRankedListApplicants
    {
        private readonly IRepositoryRankedListApplicants _repositoryRankedList;
        private readonly IRepositoryHEI _repositoryHEI;

        public ServiceRankedListApplicants(IRepositoryRankedListApplicants repositoryRankedList, IRepositoryHEI repositoryHEI)
        {
            _repositoryRankedList = repositoryRankedList;
            _repositoryHEI = repositoryHEI;
        }
        public JsonResult CreateReport(int HEI_Id)
        {
            var hei = _repositoryHEI.GetById(HEI_Id);
            var rankedList = _repositoryRankedList.GetAll().Where(item => item.HEI_Id == HEI_Id).First();

            var reportHEI = new ReportHEI(rankedList);
            var reportBilder = new ReportBuilder(reportHEI);

            return  reportBilder.GetReport();
        }

        public RankedList_DTO GetRankedList(int HEI_Id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<RankedListApplicants, RankedList_DTO>()).CreateMapper();
            return mapper.Map<RankedListApplicants, RankedList_DTO>(_repositoryRankedList.GetAll().Where(item => item.HEI_Id == HEI_Id).First());
            //var RankedList = _repositoryRankedList.GetAll().Where(item => item.HEI.Id == HEI_Id).First();
            //var returnedDTO = new RankedList_DTO() { TankedListJson = RankedList.TankedListJson, HEI = RankedList.HEI };
            //return returnedDTO;
        }

        public void AddRankedList(RankedList_DTO rankedList_DTO)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<RankedList_DTO,  RankedListApplicants > ()).CreateMapper();
            _repositoryRankedList.AddRankedList(mapper.Map<RankedList_DTO , RankedListApplicants>(rankedList_DTO));
            //var RankedList = _repositoryRankedList.GetAll().Where(item => item.HEI.Id == HEI_Id).First();
            //var returnedDTO = new RankedList_DTO() { TankedListJson = RankedList.TankedListJson, HEI = RankedList.HEI };
            //return returnedDTO;
        }
    }
}
