using Builder.Builder;
using Builder.Models;

namespace Builder.Director
{
    public class Director
    {
        public IBurgerBuilder ConstructTraditionalBurger(IBurgerBuilder builder)
        {
            builder
                .Reset()
                .SetName("Traditional")
                .SetBread(BreadType.White)
                .SetMeat(MeatType.Pork)
                .SetCheese(CheeseType.Cheddar)
                .SetSauce(SauceType.Ketchup)
                .SetVegetable(VegetableType.Tomato)
                .SetVegetable(VegetableType.Lettuce)
                .SetIsCustom(false);

            return builder;
        }

        public IBurgerBuilder ConstructVegetarianBurger(IBurgerBuilder builder)
        {
            builder
                .Reset()
                .SetName("Vegetarian")
                .SetBread(BreadType.WholeWheat)
                .SetMeat(MeatType.Vegetarian)
                .SetCheese(CheeseType.Vegan)
                .SetVegetable(VegetableType.Tomato)
                .SetVegetable(VegetableType.Lettuce)
                .SetIsCustom(false);

            return builder;
        }
    }
}
