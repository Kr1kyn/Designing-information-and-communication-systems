using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using Unified_State_System_of_Entrants.BLL.DTO;
using Unified_State_System_of_Entrants.BLL.Filters;
using Unified_State_System_of_Entrants.DAL.Interfaces;
using Unified_State_System_of_Entrants.DAL.Models;

namespace Unified_State_System_of_Entrants.BLL.Services
{
    public class ServiceHEI
    {
        private readonly IRepositoryHEI _repositoryHEI;
        public ServiceHEI(IRepositoryHEI repositoryHEI)
        {
            _repositoryHEI = repositoryHEI;
        }

        public void CreateHEI(HEI_DTO hei_DTO)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<HEI_DTO, HEI>()).CreateMapper();
            _repositoryHEI.AddHEI(mapper.Map<HEI_DTO, HEI>(hei_DTO));
        }

        public ICollection<HEI_DTO> FilterWithParameters(FilterInfo filterInfo)
        {
            var tagFilter = new FilterByTags(filterInfo.tagsForFilter);
            var cityFilter = new FilterByCity(filterInfo.cictiesForFilter);
            tagFilter.SetNext(cityFilter);

            var hEIs = _repositoryHEI.GetAll();
            ICollection<HEI> HEICollection = new List<HEI>();
            foreach (var item in hEIs)
            {
                HEICollection.Add(item);
            }

            var bilder = new HEIsFilterBilder(HEICollection);
            ICollection<HEI> result = bilder.Filter(tagFilter);

            var returnCollection = new List<HEI_DTO>();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<HEI, HEI_DTO>()).CreateMapper();
            
            foreach (var item in result)
            {
                returnCollection.Add(mapper.Map<HEI, HEI_DTO>(item));
            }            
            return returnCollection;
        }

        public HEI_DTO GetHEIProfile( int HEI_Id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<HEI, HEI_DTO>()).CreateMapper();
            return mapper.Map<HEI, HEI_DTO>(_repositoryHEI.GetById(HEI_Id));
        }


    }
}
