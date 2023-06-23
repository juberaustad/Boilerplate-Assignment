using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace session1.Controllers
{
    public class ExeperrorController : Controller
    {
        string appEnvironment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        public IActionResult Index()
        {
            return View();
        }
        [Route("ExepError/ExepError")]
        public IActionResult ExepError()
        {

            var ExceptionHandler = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.ExpPath = ExceptionHandler.Path;
            ViewBag.ExpMessage = ExceptionHandler.Error.Message;
            ViewBag.Exptrace = ExceptionHandler.Error.StackTrace;
            ViewBag.AppEnvironment = appEnvironment;
            ViewBag.adminEmail = Environment.GetEnvironmentVariable("AdminGmail");
            Log.Logger = new LoggerConfiguration().
               WriteTo.File("C:\\Users\\User\\Desktop\\Log\\Logfile.txt").CreateLogger();
            Log.Error(ExceptionHandler.Error.Message);
            return View("ExepError");

        }
    }
}
