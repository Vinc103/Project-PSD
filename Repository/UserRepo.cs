using Project_PSD.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Project_PSD.Repository.UserRepo;

namespace Project_PSD.Repository
{
    public class UserRepo
    {
        EcommerceDBEntities db = new EcommerceDBEntities();
        public interface IUserRepository
        {
            IEnumerable<User> GetAll();
            User GetById(int id);
            void Add(User user);
            void Update(User user);
            void Delete(int id);
        }
    }

    public class UserRepository : IUserRepository
    {
        public UserRepository(EcommerceDBEntities context)
        {
            Username = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.Find(id);
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}

}
