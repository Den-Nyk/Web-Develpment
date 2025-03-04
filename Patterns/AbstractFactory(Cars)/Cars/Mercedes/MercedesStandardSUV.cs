using AbstractFactory_Cars_.CarsInterface;

namespace AbstractFactory_Cars_.Cars.Mercedes
{
	public class MercedesStandardSUV : ISUV
	{
		public string GetName()
		{
			return "Mercedes gle-class";
		}
		public int GetPrice()
		{
			return 68000;
		}
		public void Drive()
		{
			Console.WriteLine("Driving a Mercedes gle-class");
		}
	}
}
