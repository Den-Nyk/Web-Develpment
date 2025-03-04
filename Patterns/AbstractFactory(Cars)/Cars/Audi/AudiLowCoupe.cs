using AbstractFactory_Cars_.CarsInterface;

namespace AbstractFactory_Cars_.Cars.Audi
{
	public class AudiLowCoupe : ICoupe
	{
		public string GetName()
		{
			return "Audi a5 coupe";
		}
		public int GetPrice()
		{
			return 30000;
		}
		public void Drive()
		{
			Console.WriteLine("Driving an Audi a5");
		}
	}
}
