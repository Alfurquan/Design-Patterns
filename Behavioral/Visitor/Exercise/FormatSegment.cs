namespace DesignPatterns.Behavioral.Visitor.Exercise
{
    public class FormatSegment : Segment
    {
        public override void Execute(IOperation operation)
        {
            operation.Apply(this); 
        }
    }
}