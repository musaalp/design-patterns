using System;

namespace Visitor
{
    public class HighlightVisitor : IVisitor
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("hightlight-heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("hightlight-anchor");
        }
    }
}
