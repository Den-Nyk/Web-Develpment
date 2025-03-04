using AbstractFactory_Cars_.CarsInterface;

namespace AbstractFactory_Cars_.Cars.Audi
{
	public class AudiHighCoupe : ICoupe
	{
		public string GetName()
		{
			return "Audi r8";
		}
		public int GetPrice()
		{
			return 100000;
		}
		public void Drive()
		{
			Console.WriteLine("Driving an Audi r8");
		}
	}
}
