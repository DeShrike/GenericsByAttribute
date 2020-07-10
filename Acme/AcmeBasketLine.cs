namespace GenericsByAttribute.Acme
{
    using GenericsByAttribute.StarkOS;
    using System.Globalization;

    public class AcmeBasketLine : BasketLine
    {
        public string ProductCode { get; set; }

        public override void ExtractExtra()
        {
            this.ProductCode = "CODE" + this.ProductId.ToString(CultureInfo.InvariantCulture);
        }
    }
}
