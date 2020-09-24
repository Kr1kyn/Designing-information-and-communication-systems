using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unified_State_System_of_Entrants.DAL.Models;

namespace Unified_State_System_of_Entrants.DAL.Interfaces
{
    public interface IRepositoryRankedListApplicants
    {
        public IQueryable<RankedListApplicants> GetAll();

        public RankedListApplicants GetById(int rankedList_id);

        public void Delete(int rankedList_id);
        public void AddRankedList(RankedListApplicants rankedList);

        public void UpdateRankedList(RankedListApplicants rankedList);
    }
}
