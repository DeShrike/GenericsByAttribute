namespace GenericsByAttribute.Choam
{
    using GenericsByAttribute.StarkOS;
    using System.Collections.ObjectModel;
    using System.Linq;

    [LineType(typeof(ChoamBasketLine))]
    public class ChoamBasket : Basket
    {
        public new ReadOnlyCollection<ChoamBasketLine> Lines => new ReadOnlyCollection<ChoamBasketLine>(base.Lines.Cast<ChoamBasketLine>().ToList());
    }
}
