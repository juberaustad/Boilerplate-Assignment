using Session4.Models;
using Session4.Repository;

namespace Session4.Sevices
{
    public class DishServices:IDishSrvices
    {
        readonly IDishRepository _dishRepository;
        public DishServices(IDishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }

        public List<Dish1> GetAllDishesV1()
        {
            return _dishRepository.GetAllDishesV1();
        }
        public List<Dish2> GetAllDishesV2()
        {
            return _dishRepository.GetAllDishesV2();
        }
    }
}
