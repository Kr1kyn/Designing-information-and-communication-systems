using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unified_State_System_of_Entrants.DAL.Models;

namespace Unified_State_System_of_Entrants.DAL.Interfaces
{
    public interface IRepositoryUser
    {
        public IQueryable<User> GetAll();

        public User GetById(int user_id);

        public void Delete(int user_id);
        public void AddUser(User user);
        public void UpdateUser(User user);
    }
}
