namespace GenericsByAttribute.Acme
{
    using GenericsByAttribute.StarkOS;
    using System.Collections.ObjectModel;
    using System.Linq;

    [LineType(typeof(AcmeBasketLine))]
    public class AcmeBasket : Basket
    {
        public new ReadOnlyCollection<AcmeBasketLine> Lines => new ReadOnlyCollection<AcmeBasketLine>(base.Lines.Cast<AcmeBasketLine>().ToList());
    }
}
