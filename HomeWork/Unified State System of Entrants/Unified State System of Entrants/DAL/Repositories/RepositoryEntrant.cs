using System.Collections.Generic;
using System.Linq;
using Unified_State_System_of_Entrants.DAL.Models;
using Unified_State_System_of_Entrants.DAL.ContextDB;
using Microsoft.EntityFrameworkCore;
using Unified_State_System_of_Entrants.DAL.Interfaces;

namespace Unified_State_System_of_Entrants.DAL.Repositories
{
    public class RepositoryEntrant : IRepositoryEntrant
    {
        private readonly UsedDbContext _db;

        public RepositoryEntrant(UsedDbContext database)
        {
            _db = database;
        }
        public IQueryable<Entrant> GetAll()
        {
            return _db.Entrants;
        }

        public Entrant GetById(int user_id)
        {
            return _db.Entrants.Find(user_id);
        }

        public void Delete(int user_id)
        {
            var entrant = _db.Entrants.Find(user_id);
            _db.Entrants.Remove(entrant);
            _db.SaveChanges();
        }
        public void AddEntrant(Entrant entrant)
        {
            _db.Entrants.Add(entrant);
            _db.SaveChanges();
        }
        
        public void UpdateEntrant(Entrant entity)
        {
            var entrantInDb = _db.Entrants.Find(entity.Id);
            entrantInDb.Name = entity.Name;
            entrantInDb.Surname = entity.Surname;
            entrantInDb.SecondName = entity.SecondName;
            entrantInDb.Sex = entity.Sex;
            entrantInDb.ResidentialAddress = entity.ResidentialAddress;
            entrantInDb.Phone = entity.Phone;
            entrantInDb.IdentityDocument = entity.IdentityDocument;
            entrantInDb.Citizenship = entity.Citizenship;
            entrantInDb.About = entity.About;
            _db.Entry(entrantInDb).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
