using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class UserManager:IUserService
    {
        IUserDal _userdal;

        public UserManager (IUserDal userdal)
        {
            _userdal = userdal;
        }

        public List<User> GetUser()
        {
            return _userdal.List();
        }

        public User GetUserByCredentials(string email, string password)
        {
            return _userdal.List(x => x.Email == email && x.Password == password).FirstOrDefault();
        }
    }
}
