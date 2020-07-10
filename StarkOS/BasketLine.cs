namespace GenericsByAttribute.StarkOS
{
    public class BasketLine
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public virtual void ExtractExtra()
        {
            // NOOP
        }
    }
}
