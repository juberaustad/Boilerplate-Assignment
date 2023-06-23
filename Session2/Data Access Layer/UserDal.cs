using Data_Access_Layer.dbContext;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class UserDal
    {
        readonly UserDbContext _userContext;

        public UserDal()
        {
                _userContext=new UserDbContext();
        }
       
        public List<User> GetAllUsers()
        {
            
            return _userContext.UserTbl.ToList(); 
        }
        public bool AddUser(User user)
        {
            _userContext.UserTbl.Add(user);
         return   _userContext.SaveChanges() == 1 ? true:false;
        }

        public User GetUserById(int id)
        {
            return _userContext.UserTbl.Where(x=>x.Id==id).FirstOrDefault();  
        }
        public bool UpdateUser(User user)
        {
            _userContext.Entry(user).State = EntityState.Modified;
            _userContext.SaveChanges();
            return true;
        }
        public bool DeleteUser(int id)
        {
             User user= _userContext.UserTbl.Where(x=>x.Id==id).FirstOrDefault();
            if (user != null)
            {
                _userContext.UserTbl.Remove(user);
                _userContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
           
        }

    }
}
