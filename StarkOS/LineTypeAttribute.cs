namespace GenericsByAttribute.StarkOS
{
    internal sealed class LineTypeAttribute : System.Attribute
    {
        public LineTypeAttribute(System.Type lineType)
        {
            this.LineType = lineType;
        }

        public System.Type LineType { get; }
    }
}
