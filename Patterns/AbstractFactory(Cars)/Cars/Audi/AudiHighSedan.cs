using AbstractFactory_Cars_.CarsInterface;

namespace AbstractFactory_Cars_.Cars.Audi
{
    public class AudiHighSedan:ISedan
    {
        public string GetName()
        {
            return "Audi a8";
        }
        public int GetPrice()
        {
            return 80000;
        }
        public void Drive()
        {
            Console.WriteLine("Driving an Audi a8");
        }
    }
}
