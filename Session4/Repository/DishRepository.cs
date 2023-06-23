using Session4.Models;

namespace Session4.Repository
{
    public class DishRepository:IDishRepository
    {
        List<Dish1> dishes1;
        List<Dish2> dishes2;
        public DishRepository()
        {
            dishes1 = new List<Dish1>()
            {
                new Dish1{Id="1-v1",Name="Spacial Biryani",Descrption="Best in State",Price=300},
                 new Dish1{Id="2-v1",Name="Chicken",Descrption="Best in Khairane",Price=450},
                  new Dish1{Id="3-v1",Name="Chicken Kolhapuri",Descrption="Best in Kolhapur",Price=350}
            };
            dishes2 = new List<Dish2>()
            {
                new Dish2{Id="1-v2",Name="Spacial Biryani Version-2",Descrption="Best in State",Price=300},
                 new Dish2{Id="2-v2",Name="Chicken Version-2",Descrption="Best in Khairane",Price=450},
                  new Dish2{Id="3-v2",Name="Chicken Kolhapuri Version-2",Descrption="Best in Kolhapur",Price=300}
            };
        }

        public List<Dish1> GetAllDishesV1()
        {
            return dishes1;
        }
        public List<Dish2> GetAllDishesV2()
        {
            return dishes2;
        }
    }
}
