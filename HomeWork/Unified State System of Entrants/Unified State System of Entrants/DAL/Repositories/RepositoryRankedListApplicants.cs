using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unified_State_System_of_Entrants.DAL.ContextDB;
using Unified_State_System_of_Entrants.DAL.Interfaces;
using Unified_State_System_of_Entrants.DAL.Models;

namespace Unified_State_System_of_Entrants.DAL.Repositories
{
    public class RepositoryRankedListApplicants : IRepositoryRankedListApplicants
    {
        private readonly UsedDbContext _db;

        public RepositoryRankedListApplicants(UsedDbContext dbContext)
        {
            _db = dbContext;
        }
        public IQueryable<RankedListApplicants> GetAll()
        {
            return _db.RankedListApplicants;
        }

        public RankedListApplicants GetById(int rankedList_id)
        {

            return _db.RankedListApplicants.Find(rankedList_id);
        }

        public void Delete(int rankedList_id)
        {
            var rankedList = _db.RankedListApplicants.Find(rankedList_id);
            _db.RankedListApplicants.Remove(rankedList);
            _db.SaveChanges();
        }
        public void AddRankedList(RankedListApplicants rankedList)
        {
            _db.RankedListApplicants.Add(rankedList);
            _db.SaveChanges();
        }

        public void UpdateRankedList(RankedListApplicants rankedList)
        {
            var rankedListInDb = _db.RankedListApplicants.Find(rankedList.Id);
            rankedListInDb.TankedList = rankedList.TankedList;
            rankedListInDb.HEI_Id = rankedList.HEI_Id;
            _db.Entry(rankedListInDb).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
