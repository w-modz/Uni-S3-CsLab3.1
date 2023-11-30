namespace S3C_Lab3
{
    internal partial class Program
    {

        interface IElectricCar
        {
            void Turn_on();
            void Turn_off();
            void Drive();
            void Fuel();
        }
        class ElectricCar : ICar, IElectricCar
        {
            public bool has_fuel;
            public bool is_on;
            public ElectricCar()
            {
                has_fuel = false;
                is_on = false;
            }
            public void Turn_on()
            {
                if (!is_on) {
                    is_on = true;
                    Console.WriteLine("Turning car on...");
                }
                else Console.WriteLine("Engine is already on");
            }
            public void Turn_off()
            {
                if (is_on) {
                    is_on = false;
                    Console.WriteLine("Turning car off...");
                }
                else Console.WriteLine("Engine is already off");
            }
            public void Drive()
            {
                if (is_on && has_fuel)
                {
                    has_fuel = false;
                    Console.WriteLine("The car is driving...");
                }
                else if (!is_on) Console.WriteLine("The car isn't on");
                else if (!has_fuel) Console.WriteLine("The car isn't charged");
            }
            public void Fuel()
            {
                if (!has_fuel)
                {
                    has_fuel = true;
                    Console.WriteLine("Charging car...");
                }
                else Console.WriteLine("Car is already charged");
            }
        }
    }
}