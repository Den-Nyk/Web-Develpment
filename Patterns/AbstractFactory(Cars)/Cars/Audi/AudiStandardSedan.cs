using AbstractFactory_Cars_.CarsInterface;

namespace AbstractFactory_Cars_.Cars.Audi
{
	public class AudiStandardSedan : ISedan
	{
		public string GetName()
		{
			return "Audi a6";
		}
		public int GetPrice()
		{
			return 60000;
		}
		public void Drive()
		{
			Console.WriteLine("Driving an Audi a6");
		}
	}
}
