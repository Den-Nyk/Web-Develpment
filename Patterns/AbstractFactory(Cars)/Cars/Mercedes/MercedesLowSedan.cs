using AbstractFactory_Cars_.CarsInterface;

namespace AbstractFactory_Cars_.Cars.Mercedes
{
    public class MercedesLowSedan : ISedan
    {
        public string GetName()
        {
            return "Mercedes c-class";
        }
        public int GetPrice()
        {
            return 30000;
        }
        public void Drive()
        {
            Console.WriteLine("Driving a Mercedes c-class");
        }
    }
}
