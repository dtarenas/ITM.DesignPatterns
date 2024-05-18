using Builder.Models;

namespace Builder.Builder
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burger _burger = new();

        public IBurgerBuilder SetBread(BreadType breadType)
        {
            _burger.Bread.Type = breadType;
            return this;
        }

        public IBurgerBuilder SetCheese(CheeseType cheeseType)
        {
            _burger.Cheese.Type = cheeseType;
            return this;
        }

        public IBurgerBuilder SetMeat(MeatType meatType)
        {
            _burger.Meat.Type = meatType;
            return this;
        }

        public IBurgerBuilder SetSauce(SauceType sauceType)
        {
            _burger.Sauces.Add(new Sauce(sauceType));
            return this;
        }

        public IBurgerBuilder SetVegetable(VegetableType vegetableType)
        {
            _burger.Vegetables.Add(new Vegetable(vegetableType));
            return this;
        }

        public IBurgerBuilder Build()
        {
            _burger.MakeBurger();
            return this;
        }

        public IBurgerBuilder SetName(string burgerName)
        {
            _burger.Name = burgerName;
            return this;
        }

        public IBurgerBuilder Reset()
        {
            _burger = new();
            return this;
        }
    }
}
