namespace Visitor_Animals_.Animals
{
    internal class Dog:IAnimal
    {
        public Dog(string name)
        { Name = name; }
        public string Name { get; set; }
        public void tellAboutItSelf()
        {
            Console.WriteLine("I am dog, my name is "+ Name);
        }
        public void Accept(IAnimalVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
