namespace GenericsByAttribute.Choam
{
    using GenericsByAttribute.StarkOS;

    public class ChoamBasketLine : BasketLine
    {
        public decimal ProductPrice { get; set; }

        public override void ExtractExtra()
        {
            this.ProductPrice = this.ProductId / 10M;
        }
    }
}
