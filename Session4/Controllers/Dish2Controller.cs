using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Session4.Models;
using Session4.RModel;
using Session4.Sevices;

namespace Session4.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("2.2")]
    public class Dish2Controller : ControllerBase
    {
        readonly IDishSrvices _dishService;
        readonly ILogger<Dish2Controller> _logger;
        readonly IDataProtector _dataProtector;
        public Dish2Controller(IDishSrvices dishServices, ILogger<Dish2Controller> logger, IDataProtectionProvider provider)
        {
            _dishService = dishServices;
            _logger = logger;
            _dataProtector = provider.CreateProtector("");
        }
        [HttpGet]

        public ActionResult GetAllDishes()
        {
            _logger.Log(LogLevel.Information, $"List of Dishes Returned V--2.2");
            List<Dish2> dishesV2 = _dishService.GetAllDishesV2();
            dishesV2.ForEach(c =>
            {
                c.Id = _dataProtector.Protect((c.Id).ToString());
            });
            Response ResData = new Response()
            {
                Errors = null,
                Message = "Success",
                Data = dishesV2,
                Succeeded = true
            };
            return Ok(ResData);
        }
    }
}
