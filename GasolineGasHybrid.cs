namespace S3C_Lab3
{
    internal partial class Program
    {
        class GasolineGasHybrid : ICar, IGasolineCar, IGasCar
        {
            public bool has_gasoline;
            public bool has_gas;
            public bool is_on;
            public GasolineGasHybrid()
            {
                has_gas = false;
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
                else if (is_on && has_gas)
                {
                    has_gas = false;
                    Console.WriteLine("The car is driving on gas...");
                }
                else if (!is_on) Console.WriteLine("The car isn't on");
                else if (!has_gasoline) Console.WriteLine("The car isn't fueled with gasoline");
                else if (!has_gas) Console.WriteLine("The car isn't fueled with gas");
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
            void IGasCar.Drive()
            {
                if (is_on && has_gas)
                {
                    has_gas = false;
                    Console.WriteLine("The car is driving on gas...");
                }
                else if (!is_on) Console.WriteLine("The car isn't on");
                else if (!has_gas) Console.WriteLine("The car isn't fueled with gas");
            }
            void ICar.Fuel()
            {
                if (!has_gasoline)
                {
                    has_gasoline = true;
                    Console.WriteLine("Tanking car with gasoline...");
                }
                else Console.WriteLine("Car is already fueled with gasoline");
                if (!has_gas)
                {
                    has_gas = true;
                    Console.WriteLine("Tanking car with gas...");
                }
                else Console.WriteLine("Car is already fueled with gas");
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
            void IGasCar.Fuel()
            {
                if (!has_gas)
                {
                    has_gas = true;
                    Console.WriteLine("Tanking car with gas...");
                }
                else Console.WriteLine("Car is already fueled with gas");
            }
        }
    }
}