using System;
using System.Collections.Generic;
using Unified_State_System_of_Entrants.DAL.Models;
using System.Text;
using System.Linq;
using Unified_State_System_of_Entrants.DAL.ContextDB;
using Microsoft.EntityFrameworkCore;
using Unified_State_System_of_Entrants.DAL.Interfaces;

namespace Unified_State_System_of_Entrants.DAL.Repositories
{
    public class RepositoryHEI :IRepositoryHEI
    {
        private readonly UsedDbContext _db;

        public RepositoryHEI(UsedDbContext dbContext)
        {
            _db = dbContext;
        }
        public IQueryable<HEI> GetAll()
        {
            return _db.HEIs;
        }

        public HEI GetById(int HEI_id)
        {

            return _db.HEIs.Find(HEI_id);
        }

        public void Delete(int HEI_id)
        {
            var hEI = _db.HEIs.Find(HEI_id);
            _db.HEIs.Remove(hEI);
            _db.SaveChanges();
        }
        public void AddHEI(HEI hei)
        {
            _db.HEIs.Add(hei);
            _db.SaveChanges();
        }

        public void UpdateHEI(HEI hei)
        {
            var HEIInDb = _db.HEIs.Find(hei.Id);
            HEIInDb.Name = hei.Name;
            HEIInDb.Description = hei.Description;
            HEIInDb.InformationLinks = hei.InformationLinks;
            HEIInDb.Locations = hei.Locations;
            HEIInDb.TagsForFilter = hei.TagsForFilter;
            _db.Entry(HEIInDb).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
