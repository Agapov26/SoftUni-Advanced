namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string pizzaName = Console.ReadLine().Split()[1];
                string[] doughInput = Console.ReadLine().Split();
                Dough dough = new Dough(doughInput[1], doughInput[2], int.Parse(doughInput[3]));

                Pizza pizza = new Pizza(pizzaName, dough);

                string[] toppingInput;
                while ((toppingInput = Console.ReadLine().Split())[0] != "END")
                {
                    pizza.AddTopping(new Topping(toppingInput[1], int.Parse(toppingInput[2])));
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
