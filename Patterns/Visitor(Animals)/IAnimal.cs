namespace Visitor_Animals_
{
    internal interface IAnimal
    {
        void Accept(IAnimalVisitor visitor);
        string Name { get; set; }
        void tellAboutItSelf();
    }
}
