namespace Visitor
{
    public class HeadingNode : IHtmNode
    {
        public void Execute(IVisitor visitor)
        {
            visitor.Apply(this);
        }
    }
}