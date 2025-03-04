namespace Visitor_Animals_.Animals
{
    internal class Bird:IAnimal
    {
        public Bird(string name) { Name = name; }
        public string Name { get; set; }
        public void tellAboutItSelf()
        {
            Console.WriteLine("I am bird, my name is " + Name);
        }
        public void Accept(IAnimalVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
