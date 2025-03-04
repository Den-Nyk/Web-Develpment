using AbstractFactory_Cars_.CarsInterface;

namespace AbstractFactory_Cars_.CarFactoryInterface
{
    public enum CarSegment
    {
        Low,
        Standard,
        High
    }
    internal interface ICarFactory
    {
        ISedan CreateSedan(CarSegment segment);
        ISUV CreateSUV(CarSegment segment);
        ICoupe CreateCoupe(CarSegment segment);
    }
}
