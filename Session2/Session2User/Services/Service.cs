

using AutoMapper;
using Data_Access_Layer.Entities;
using Session2User.Interface;
using Session2User.Models;

namespace Session2User.Services
{
    
    public class Service: IService
    {
        private Data_Access_Layer.UserDal dal;
        private Mapper _userMapper;
        private Mapper _userViewModel;

        public Service()
        {
            dal = new Data_Access_Layer.UserDal();
            var _configUser = new MapperConfiguration(cfg => cfg.CreateMap<User, UserModel>().ReverseMap());
            _userMapper =new Mapper(_configUser);
           var _configUserViewModel = new MapperConfiguration(cfg => cfg.CreateMap<User, UserViewModel>().ReverseMap());
            _userViewModel = new Mapper(_configUserViewModel);
        } 
        public List<UserModel> GetAllUser()
        {
            List<User> user = dal.GetAllUsers();
            List<UserModel> userModel = _userMapper.Map<List<User>,List< UserModel>>(user);
            return userModel;
         
        }

        public bool AddUser(UserViewModel UVmodel)
        {  
            //UserModel userM=new UserModel();


            User user = _userViewModel.Map<UserViewModel,User>(UVmodel);
           return dal.AddUser(user);  
        }
        public UserModel GetUserById(int id)
        {
            User user = dal.GetUserById(id);
            UserModel userM= _userMapper.Map<User,UserModel>(user);
            return userM;
        }
        public bool EditUser(UserModel Umodel)
        {
            User user = _userMapper.Map<UserModel, User>(Umodel);

            return dal.UpdateUser(user);
        }

        public bool DeleteUser(int id)
        {
            return dal.DeleteUser(id);
        }
    }
}
