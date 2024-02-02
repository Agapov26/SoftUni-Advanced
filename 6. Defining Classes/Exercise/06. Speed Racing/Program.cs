namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] car = Console.ReadLine().Split();

                string model = car[0];
                double fuelAmount = double.Parse(car[1]);
                double fuelConsumption = double.Parse((car[2]));

                cars.Add(new Car(model, fuelAmount, fuelConsumption));
            }

            string[] input = Console.ReadLine().Split();
            while (input[0] != "End")
            {
                if (input[0] == "Drive")
                {
                    string model = input[1];
                    Car currCar = cars.Find(c => c.Model.Equals(model));
                    double distance = double.Parse(input[2]);
                    currCar.Drive(distance);
                }
                input = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join(Environment.NewLine, cars));
        }
    }
}

