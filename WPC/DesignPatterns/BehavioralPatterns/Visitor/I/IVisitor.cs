namespace WPC.DesignPatterns.BehavioralPatterns.Visitor.I
{
    public interface IVisitor
    {
        void Visit(PlainText plainText);
        void Visit(BoldText boldText);
        void Visit(Hyperlink hyperlink);
    }
}