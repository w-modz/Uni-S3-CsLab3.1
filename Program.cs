namespace S3C_Lab3
{
    internal partial class Program
    {
        static void Main()
        {
            ICar[] cars = new ICar[5];
            cars[0] = new GasolineCar();
            cars[1] = new GasCar();
            cars[2] = new ElectricCar();
            cars[3] = new GasolineGasHybrid();
            cars[4] = new GasolineElectricHybrid();
            for (int i = 0; i < cars.Length; i++)
            {
                TestDrive(cars[i]);
            }
            Console.WriteLine("");
            ((IGasolineCar)cars[3]).Fuel();
            ((IGasolineCar)cars[4]).Fuel();
            Console.WriteLine("");
            ((ICar)cars[3]).Fuel();
            ((ICar)cars[4]).Fuel();
            return;
        }
        // Method for testing outputs of Car class objects
        static void TestDrive(ICar car)
        {
            Console.WriteLine("");
            car.Fuel();
            car.Fuel();
            car.Drive();
            car.Turn_on();
            car.Turn_on();
            car.Drive();
            car.Drive();
            car.Turn_off();
            car.Turn_off();
        }
    }
}