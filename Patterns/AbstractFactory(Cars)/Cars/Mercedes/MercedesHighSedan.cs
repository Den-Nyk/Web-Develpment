using AbstractFactory_Cars_.CarsInterface;

namespace AbstractFactory_Cars_.Cars.Mercedes
{
    public class MercedesHighSedan : ISedan
    {
        public string GetName()
        {
            return "Mercedes s-class";
        }
        public int GetPrice()
        {
            return 100000;
        }
        public void Drive()
        {
            Console.WriteLine("Driving a Mercedes s-class");
        }
    }
}
