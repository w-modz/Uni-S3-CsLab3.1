namespace S3C_Lab3
{
    internal partial class Program
    {
        class GasolineElectricHybrid : ICar, IGasolineCar, IElectricCar
        {
            public bool has_gasoline;
            public bool has_electricity;
            public bool is_on;
            public GasolineElectricHybrid()
            {
                has_electricity = false;
                has_gasoline = false;
                is_on = false;
            }
            public void Turn_on()
            {
                if (!is_on)
                {
                    is_on = true;
                    Console.WriteLine("Turning car on...");
                }
                else Console.WriteLine("Engine is already on");
            }
            public void Turn_off()
            {
                if (is_on)
                {
                    is_on = false;
                    Console.WriteLine("Turning car off...");
                }
                else Console.WriteLine("Engine is already off");
            }
            void ICar.Drive()
            {
                if (is_on && has_gasoline)
                {
                    has_gasoline = false;
                    Console.WriteLine("The car is driving on gasoline...");
                }
                else if (is_on && has_electricity)
                {
                    has_electricity = false;
                    Console.WriteLine("The car is driving on electricity...");
                }
                else if (!is_on) Console.WriteLine("The car isn't on");
                else if (!has_gasoline) Console.WriteLine("The car isn't fueled with gasoline");
                else if (!has_electricity) Console.WriteLine("The car isn't charged");
            }
            void IGasolineCar.Drive()
            {
                if (is_on && has_gasoline)
                {
                    has_gasoline = false;
                    Console.WriteLine("The car is driving on gasoline...");
                }
                else if (!is_on) Console.WriteLine("The car isn't on");
                else if (!has_gasoline) Console.WriteLine("The car isn't fueled with gasoline");
            }
            void IElectricCar.Drive()
            {
                if (is_on && has_electricity)
                {
                    has_electricity = false;
                    Console.WriteLine("The car is driving on electricity...");
                }
                else if (!is_on) Console.WriteLine("The car isn't on");
                else if (!has_electricity) Console.WriteLine("The car isn't charged");
            }
            void ICar.Fuel()
            {
                if (!has_gasoline)
                {
                    has_gasoline = true;
                    Console.WriteLine("Tanking car with gasoline...");
                }
                else Console.WriteLine("Car is already fueled with gasoline");
                if (!has_electricity)
                {
                    has_electricity = true;
                    Console.WriteLine("Charging car...");
                }
                else Console.WriteLine("Car is already charged");
            }
            void IGasolineCar.Fuel()
            {
                if (!has_gasoline)
                {
                    has_gasoline = true;
                    Console.WriteLine("Tanking car with gasoline...");
                }
                else Console.WriteLine("Car is already fueled with gasoline");
            }
            void IElectricCar.Fuel()
            {
                if (!has_electricity)
                {
                    has_electricity = true;
                    Console.WriteLine("Charging car...");
                }
                else Console.WriteLine("Car is already charged");
            }
        }
    }
}