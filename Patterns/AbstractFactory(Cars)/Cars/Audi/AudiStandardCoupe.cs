using AbstractFactory_Cars_.CarsInterface;

namespace AbstractFactory_Cars_.Cars.Audi
{
	public class AudiStandardCoupe : ICoupe
	{
		public string GetName()
		{
			return "Audi tt";
		}
		public int GetPrice()
		{
			return 55000;
		}
		public void Drive()
		{
			Console.WriteLine("Driving an Audi tt");
		}
	}
}
