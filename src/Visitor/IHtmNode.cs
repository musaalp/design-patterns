namespace Visitor
{
    public interface IHtmNode
    {
        void Execute(IVisitor visitor);
    }
}
