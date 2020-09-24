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
    public class RepositoryUser : IRepositoryUser
    {
        private readonly UsedDbContext _db;

        public RepositoryUser(UsedDbContext database)
        {
            _db = database;
        }
        public IQueryable<User> GetAll()
        {
            return _db.Users;
        }

        public User GetById(int user_id)
        {
            return _db.Users.Find(user_id);
        }

        public void Delete(int user_id)
        {
            var user = _db.Users.Find(user_id);
            _db.Users.Remove(user);
            _db.SaveChanges();
        }
        public void AddUser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            var userInDb = _db.Users.Find(user.Id);

            userInDb.Email = user.Email;
            userInDb.Login = user.Login;
            userInDb.Nickname = user.Nickname;
            userInDb.Password = user.Password;
            _db.Entry(userInDb).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
