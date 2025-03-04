using AbstractFactory_Cars_.CarsInterface;

namespace AbstractFactory_Cars_.Cars.Mercedes
{
	public class MercedesHighSUV : ISUV
	{
		public string GetName()
		{
			return "Mercedes g-class";
		}
		public int GetPrice()
		{
			return 150000;
		}
		public void Drive()
		{
			Console.WriteLine("Driving a Mercedes g-class");
		}
	}
}