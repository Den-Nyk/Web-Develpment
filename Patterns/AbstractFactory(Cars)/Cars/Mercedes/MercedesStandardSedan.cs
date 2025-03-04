using AbstractFactory_Cars_.CarsInterface;

namespace AbstractFactory_Cars_.Cars.Mercedes
{
	public class MercedesStandardSedan : ISedan
	{
		public string GetName()
		{
			return "Mercedes e-class";
		}
		public int GetPrice()
		{
			return 50000;
		}
		public void Drive()
		{
			Console.WriteLine("Driving a Mercedes e-class");
		}
	}
}
