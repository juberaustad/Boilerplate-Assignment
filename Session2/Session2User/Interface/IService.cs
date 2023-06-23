using Session2User.Models;

namespace Session2User.Interface
{
    public interface IService
    {
        public List<UserModel> GetAllUser();
        public bool AddUser(UserViewModel UVmodel);
        public UserModel GetUserById(int id);
        public bool EditUser(UserModel Umodel);
        public bool DeleteUser(int id);
    }
}
