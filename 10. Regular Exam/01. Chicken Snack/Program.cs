namespace _01._Chicken_Snack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> amountOfMoney = new Stack<int>();
            Queue<int> priceOfFoods = new Queue<int>();

            string[] moneyInput = Console.ReadLine().Split();

            foreach (string amount in moneyInput)
            {
                amountOfMoney.Push(int.Parse(amount));
            }

            string[] priceInput = Console.ReadLine().Split();

            foreach (string price in priceInput)
            {
                priceOfFoods.Enqueue(int.Parse(price));
            }

            int foodCount = 0;

            while (amountOfMoney.Count > 0 && priceOfFoods.Count > 0)
            {
                int currentMoney = amountOfMoney.Pop();
                int currentPrice = priceOfFoods.Peek();

                if (currentMoney == currentPrice)
                {
                    foodCount++;
                    priceOfFoods.Dequeue();
                }

                else if (currentMoney > currentPrice)
                {
                    foodCount++;
                    int change = currentMoney - currentPrice;
                    int nextM = amountOfMoney.Count > 0 ? amountOfMoney.Pop() : 0;
                    nextM += change;
                    amountOfMoney.Push(nextM);
                    priceOfFoods.Dequeue();
                }

                else
                {
                    priceOfFoods.Dequeue();
                }
            }

            if (foodCount >= 4)
            {
                Console.WriteLine($"Gluttony of the day! Henry ate {foodCount} foods.");
            }

            else if (foodCount > 0)
            {
                Console.WriteLine($"Henry ate: {foodCount} food{(foodCount > 1 ? "s" : "")}.");
            }

            else
            {
                Console.WriteLine("Henry remained hungry. He will try next weekend again.");
            }
        }
    }
}
