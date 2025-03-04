namespace Visitor_Animals_.Animals
{
    internal class Cat:IAnimal
    {
        public Cat(string name) { Name = name; }
        public string Name { get; set; }
        public void tellAboutItSelf()
        {
            Console.WriteLine("I am cat, my name is " + Name);
        }
        public void Accept(IAnimalVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
