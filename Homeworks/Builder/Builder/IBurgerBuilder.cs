using Builder.Models;

namespace Builder.Builder
{
    public interface IBurgerBuilder
    {
        IBurgerBuilder SetName(string burgerName);
        IBurgerBuilder SetBread(BreadType breadType);
        IBurgerBuilder SetMeat(MeatType meatType);
        IBurgerBuilder SetCheese(CheeseType cheeseType);
        IBurgerBuilder SetVegetable(VegetableType vegetableType);
        IBurgerBuilder SetSauce(SauceType sauceType);
        IBurgerBuilder SetIsCustom(bool isCustom);
        IBurgerBuilder Reset();
        Burger Build();
    }
}
