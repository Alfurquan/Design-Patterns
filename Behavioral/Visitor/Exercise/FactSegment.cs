namespace DesignPatterns.Behavioral.Visitor.Exercise
{
    public class FactSegment : Segment
    {
        public override void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}