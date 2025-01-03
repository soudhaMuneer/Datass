using Chapter10Exercise1.Interface;
using Chapter10Exercise1.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter10Exercise1.Reprostry
{
    public class UserReprostry : IUserReprostry
    {
        JobportalEx3CH10DbContext db;
        public UserReprostry( JobportalEx3CH10DbContext db)
        {
            this.db = db;
        }

        public Users register(Users user)
        {
            db.User.Add(user);
            db.SaveChanges();
            return user;
        }
        public Users Login(string email, string password)
        {
            Users res = db.User.Where(e => e.Email == email && e.Password == password).FirstOrDefault();
            return res;

        }
    }
}
