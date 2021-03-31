using System;

namespace WPC.DesignPatterns.BehavioralPatterns.Visitor.II
{
    public class BoxedProduct : Product
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        public override void PrintType()
        {
            Console.WriteLine("BoxedProduct");
        }
    }
}
