namespace S3C_Lab3
{
    internal partial class Program
    {
        interface IGasCar
        {
            void Turn_on();
            void Turn_off();
            void Drive();
            void Fuel();
        }
        class GasCar : ICar, IGasCar
        {
            public bool has_fuel;
            public bool is_on;
            public GasCar()
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
                else if (!has_fuel) Console.WriteLine("The car isn't fueled with gas");
            }
            public void Fuel()
            {
                if (!has_fuel) {
                    has_fuel = true;
                    Console.WriteLine("Fueling car with gas...");
                }
                else Console.WriteLine("Car is already fueled with gas");
            }
        }
    }
}