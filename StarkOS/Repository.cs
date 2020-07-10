namespace GenericsByAttribute.StarkOS
{
    using System.Collections.Generic;

    public class Repository
    {
        public TBasket LoadData<TBasket>()
            where TBasket : Basket, new()
        {
            var basket = new TBasket();

            var lineType = typeof(BasketLine);
            var lineTypeAttribute = (LineTypeAttribute)System.Attribute.GetCustomAttribute(basket.GetType(), typeof(LineTypeAttribute));
            if (lineTypeAttribute != null)
            {
                lineType = lineTypeAttribute.LineType;
            }

            ////var type = typeof(List<>).MakeGenericType(lineType);
            ////var list = (IEnumerable<object>)System.Activator.CreateInstance(type);
            ////basket.Lines = (List<BasketLine>)list.Cast<BasketLine>();

            basket.Lines = new List<BasketLine>();

            // Add Line
            var line1 = System.Activator.CreateInstance(lineType) as BasketLine;
            line1.Id = 42;
            line1.ProductId = 42;
            line1.ExtractExtra();
            basket.Lines.Add(line1);

            // Add Line
            var line2 = System.Activator.CreateInstance(lineType) as BasketLine;
            line2.Id = 666;
            line2.ProductId = 666;
            line2.ExtractExtra();
            basket.Lines.Add(line2);

            // Add Line
            var line3 = System.Activator.CreateInstance(lineType) as BasketLine;
            line3.Id = 58008;
            line3.ProductId = 58008;
            line3.ExtractExtra();
            basket.Lines.Add(line3);

            return basket;
        }
    }
}
