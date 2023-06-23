using Microsoft.AspNetCore.Mvc;
using session1.Models;
using session1.Services;

namespace session1.Controllers
{
    public class UserController : Controller
    {
        readonly IServices _services;
        public UserController(IServices services)
        {
            _services = services;
        }
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Prints the A single user Detail getting from Addsettings.json
        /// </summary>
        /// <returns> user </returns>
        public ActionResult PrintDetails()
        {
            //throw new Exception("this is the exception for testing");
            User user = _services.PrintDetails();

            return View(user);
        }


        /// <summary>
        /// Gets all the User list
        /// </summary>
        /// <returns> "List<User>"</returns>
        public ActionResult GetAllUser()
        {
            List<User> Users = _services.GetAllUsers();
            return View(Users);
        }


        /// <summary>
        /// Adds
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(UserViewModel userView)
        {
            bool status = _services.AddUser(userView);

            return View();
        }

    }
}
