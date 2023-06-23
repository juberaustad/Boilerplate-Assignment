using Microsoft.AspNetCore.Mvc;
using Session2User.Interface;
using Session2User.Models;

namespace Session2User.Controllers
{
    public class UserController : Controller
    {
        readonly IService _userService;
        public UserController(IService userService)
        {
            _userService = userService;
        }
    
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetAllUser()
        {
            List<UserModel> userModels = _userService.GetAllUser();
            return View(userModels);

        }
        [HttpGet]

        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(UserViewModel viewModel)
        {
            bool Status = _userService.AddUser(viewModel);
            if (Status == true)
            {
                TempData["AddMsg"] = "Sucessfully Added";
                TempData["Pass"] = "Pass";
                ModelState.Clear();
            }
            return View();
        }

        [HttpGet]

        public ActionResult EditUser(int id)
        {
            UserModel userM = _userService.GetUserById(id);
            return View(userM);
        }
        [HttpPost]
        public ActionResult EditUser(UserModel userModel)
        {
            Console.WriteLine(userModel);
            bool status = _userService.EditUser(userModel);
            if (status == true)
            {
                TempData["AddUpdtMsg"] = "Sucessfully Updated";
                TempData["Updt"] = "Edit";
                ModelState.Clear();
            }
            return View();
        }
        [HttpGet]
        public ActionResult DeleteUser(int id)
        {
            UserModel userM = _userService.GetUserById(id);
            return View(userM);
        }
        [HttpPost]
        public ActionResult DeleteUser(string id)
        {
            int idx = int.Parse(id);
            bool status= _userService.DeleteUser(idx);
            //return RedirectToAction("GetAllUser");
            return RedirectToAction("GetAllUser");
        }


    }
}
