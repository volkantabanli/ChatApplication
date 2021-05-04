using DataAccessLayer.Concrete.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public  class UserManager
    {

        GenericRepository<User> repo = new GenericRepository<User>();
        public List<User> GetAll()
        {

            return repo.List();
        }

        public List<User> GetOthers(User user)
        {
            return repo.List(m => m.Mail != user.Mail && m.Password != user.Password);
        }

        public User GetUser(User user)
        {
            return repo.List(m => m.Mail == user.Mail && m.Password == user.Password).FirstOrDefault();
        }

        public User GetReceivedUser(int recieveUserId)
        {
            return repo.List(m => m.UserId == recieveUserId).FirstOrDefault();
        }
    }
}
