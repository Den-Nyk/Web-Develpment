using AbstractFactory_Cars_.CarsInterface;

namespace AbstractFactory_Cars_.Cars.Audi
{
	public class AudiLowSedan : ISedan
	{
		public string GetName()
		{
			return "Audi a3";
		}
		public int GetPrice()
		{
			return 20000;
		}
		public void Drive()
		{
			Console.WriteLine("Driving an Audi a3");
		}
	}
}
