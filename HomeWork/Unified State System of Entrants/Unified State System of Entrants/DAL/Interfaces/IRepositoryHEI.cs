using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unified_State_System_of_Entrants.DAL.Models;

namespace Unified_State_System_of_Entrants.DAL.Interfaces
{
    public interface IRepositoryHEI 
    {
        public IQueryable<HEI> GetAll();

        public HEI GetById(int user_id);

        public void Delete(int user_id);
        public void AddHEI(HEI entrant);

        public void UpdateHEI(HEI entrant);
    }
}
