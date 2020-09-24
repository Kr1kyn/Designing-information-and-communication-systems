using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Unified_State_System_of_Entrants.BLL.DTO;
using Unified_State_System_of_Entrants.DAL.Interfaces;
using Unified_State_System_of_Entrants.DAL.Models;

namespace Unified_State_System_of_Entrants.BLL.Services
{
    public class ServiceUser
    {
        private readonly IRepositoryUser _repositoryUser;
        public ServiceUser(IRepositoryUser repositoryUser)
        {
            _repositoryUser = repositoryUser;
        }

        public void CreateUser(User_DTO user_DTO)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<User_DTO, User>()).CreateMapper();
            _repositoryUser.AddUser(mapper.Map<User_DTO, User>(user_DTO));
        }
    }
}
/*
{
    "id": 0,
  "login": "NewLogin",
  "password": "P@$$w0rd",
  "email": "Email@mail.ru",
  "nickname": "MyNikname"
}
*/