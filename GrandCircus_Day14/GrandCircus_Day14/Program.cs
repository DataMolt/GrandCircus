using System;

namespace GrandCircus_Day14
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine dieselEngine = new DieselEngine();
            dieselEngine.Drive();
            dieselEngine.HorsePower = 420;
            Console.WriteLine(dieselEngine.HorsePower);

            var truck = new Truck();
            HonkSomething(truck);

            DoVehicleThings(truck);

            Console.ReadLine();
        }

        public static void HonkSomething(IHonk honk)
        {
            Console.WriteLine(honk.Honk());
        }

        public static void DoVehicleThings(IVehicle vehicle)
        {
            Console.WriteLine(vehicle.Honk());
            vehicle.Brake();
        }
    }
}
