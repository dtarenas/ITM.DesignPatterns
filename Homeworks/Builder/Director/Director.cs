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
                .Build();

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
                .Build();

            return builder;
        }

        //public IBurgerBuilder ConstructCustomBurger(IBurgerBuilder builder)
        //{
        //    builder
        //        .Reset()
        //        .SetName("ITM Burger")
        //        .SetBread(BreadType.Cassava)
        //        .SetMeat(MeatType.Pork)
        //        .SetCheese(CheeseType.Mozzarella)
        //        .SetSauce(SauceType.Ketchup)
        //        .SetSauce(SauceType.Mustard)
        //        .SetVegetable(VegetableType.Lettuce)
        //        .Build();

        //    return builder;
        //}
    }
}
