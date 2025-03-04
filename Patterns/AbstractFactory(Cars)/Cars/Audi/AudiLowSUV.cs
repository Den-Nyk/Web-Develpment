using AbstractFactory_Cars_.CarsInterface;

namespace AbstractFactory_Cars_.Cars.Audi
{
	public class AudiLowSUV : ISUV
	{
		public string GetName()
		{
			return "Audi q3";
		}
		public int GetPrice()
		{
			return 40000;
		}
		public void Drive()
		{
			Console.WriteLine("Driving an Audi q3");
		}
	}
}
