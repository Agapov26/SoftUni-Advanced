namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new CarBuilderFacade()
                .Info.
                WithType("Mazda 3").
                WithColor("Dark blue")
                .WithNumberOfDoors(5).
                Built.
                InCity("Hofu").
                AtAdress("Some address")
                .Build();

            Console.WriteLine(car);
        }
    }
}
