using AbstractFactory_Cars_.CarsInterface;

namespace AbstractFactory_Cars_.Cars.Mercedes
{
	public class MercedesLowSUV : ISUV
	{
		public string GetName()
		{
			return "Mercedes glc-class";
		}
		public int GetPrice()
		{
			return 40000;
		}
		public void Drive()
		{
			Console.WriteLine("Driving a Mercedes glc-class");
		}
	}
}
