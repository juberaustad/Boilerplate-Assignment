using Session4.Models;

namespace Session4.Repository
{
    public interface IDishRepository
    {
        public List<Dish1> GetAllDishesV1();
        public List<Dish2> GetAllDishesV2();
    }
}
