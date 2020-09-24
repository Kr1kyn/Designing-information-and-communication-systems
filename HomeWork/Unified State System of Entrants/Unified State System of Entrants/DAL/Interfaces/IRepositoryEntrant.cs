using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unified_State_System_of_Entrants.DAL.Models;

namespace Unified_State_System_of_Entrants.DAL.Interfaces
{
    public interface IRepositoryEntrant
    {
        public IQueryable<Entrant> GetAll();

        public Entrant GetById(int user_id);

        public void Delete(int user_id);
        public void AddEntrant(Entrant entrant);

        public void UpdateEntrant(Entrant entrant);
    }
}
