using System;

namespace Visitor
{
    public class PlainTextHighlightVisitor : IVisitor
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("text-heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("text-anchor");
        }
    }
}
