using session1.Models;

namespace session1.Services
{
    public class Services:IServices
    {
        readonly IConfiguration _configuration;
        List<User> users = new List<User>();
        int Idcount;
        public Services(IConfiguration configuration)
        {
            _configuration = configuration;
            Idcount = 2;
        }

        /// <summary>
        /// This method will  get All the values of User From the List and return the list
        /// </summary>
        /// <returns> "List<User>" </returns>

        public List<User> GetAllUsers()
        {
            Console.WriteLine("inside the getAll User");
            foreach (User use in users)
            {
                Console.WriteLine($"Name:{use.UserName} // Age:{use.UserAge}");
            }
            return users.ToList();
        }

        /// <summary>
        /// This method will  just print a Detail of user getting value from AppSettings.json
        /// </summary>
        /// <returns> User</returns>
        public User PrintDetails()
        {
            User user = new User();
            user.UId = 1;
            user.UserName = _configuration.GetValue<string>("DummyData:name");
            user.UserAge = int.Parse(_configuration.GetValue<string>("DummyData:age"));
            user.Email = _configuration.GetValue<string>("DummyData:email");
            users.Add(user);
            foreach (User use in users)
            {
                Console.WriteLine($"Name:{use.UserName} // Age:{use.UserAge}");
            }
            return user;
        }
        /// <summary>
        /// This method will Add the new user To list
        /// </summary>
        /// <param name="userView"></param>
        /// <returns> bool</returns>
        public bool AddUser(UserViewModel userView)
        {
            User user = new User();
            user.UId = Idcount;
            user.UserName = userView.UserName;
            user.UserAge = userView.UserAge;
            user.Email = userView.Email;
            users.Add(user);
            Console.WriteLine(user.UserName);
            foreach (User use in users)
            {
                Console.WriteLine($"Name:{use.UserName} // Age:{use.UserAge}");
            }
            Idcount++;
            return true;
        }
        public bool DeleteUser(int id)
        {
            User userr = users.Where(x => x.UId == id).FirstOrDefault();
            users.Remove(userr);
            return true;
        }
        public bool UpdateUser(User user)
        {
            User userr = users.Where(x => x.UId == user.UId).FirstOrDefault();
            if (userr != null)
            {
                //userr.UId = user.UId;
                userr.UserName = user.UserName;
                userr.UserAge = user.UserAge;
                userr.Email = user.Email;

            }
            return true;
        }


    }
}
