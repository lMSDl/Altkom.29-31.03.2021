namespace WPC.DesignPatterns.BehavioralPatterns.Visitor.II
{
    public interface IVisitor
    {
        void Visit(Product product);
        void Visit(BoxedProduct product);
    }
}