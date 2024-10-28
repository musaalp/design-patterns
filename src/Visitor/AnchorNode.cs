namespace Visitor
{
    public class AnchorNode : IHtmNode
    {
        public void Execute(IVisitor visitor)
        {
            visitor.Apply(this);
        }
    }
}