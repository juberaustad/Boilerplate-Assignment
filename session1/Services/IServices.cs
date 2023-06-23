using session1.Models;

namespace session1.Services
{
    public interface IServices
    {
        public User PrintDetails();
        public bool AddUser(UserViewModel userView);
        public List<User> GetAllUsers();
        public bool DeleteUser(int id);
        public bool UpdateUser(User user);
    }
}
