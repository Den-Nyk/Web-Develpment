using AbstractFactory_Cars_.CarsInterface;

namespace AbstractFactory_Cars_.Cars.Audi
{
	public class AudiStandardSUV : ISUV
	{
		public string GetName()
		{
			return "Audi q5";
		}
		public int GetPrice()
		{
			return 60000;
		}
		public void Drive()
		{
			Console.WriteLine("Driving an Audi q5");
		}
	}
}
