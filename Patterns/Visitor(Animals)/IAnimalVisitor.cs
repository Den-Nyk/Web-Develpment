using Visitor_Animals_.Animals;

namespace Visitor_Animals_
{
    internal interface IAnimalVisitor
    {
        void Visit(Dog dog);
        void Visit(Cat cat);
        void Visit(Bird bird);
    }
}
