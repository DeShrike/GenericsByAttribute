using System.Collections.Generic;

namespace GenericsByAttribute.StarkOS
{
    public class Basket
    {
        public int Id { get; set; }

        public List<BasketLine> Lines { get; set; }

        public string MiscXml { get; set; }
    }
}
