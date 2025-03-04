using AbstractFactory_Cars_.CarsInterface;

namespace AbstractFactory_Cars_.Cars.Audi
{
	public class AudiHighSUV : ISUV
	{
		public string GetName()
		{
			return "Audi q7";
		}
		public int GetPrice()
		{
			return 90000;
		}
		public void Drive()
		{
			Console.WriteLine("Driving an Audi q7");
		}
	}
}
