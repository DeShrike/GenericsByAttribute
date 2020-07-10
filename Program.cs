namespace GenericsByAttribute
{
    using System;
    using GenericsByAttribute.StarkOS;

    public class Program
    {
        private static void Main(string[] args)
        {
            AcmeTest();
            ChoamTest();
        }

        private static void AcmeTest()
        {
            Console.WriteLine("ACME");
            var repo = new Repository();
            var basket = repo.LoadData<Acme.AcmeBasket>();
            foreach (var line in basket.Lines)
            {
                Console.WriteLine("{0} - {1} - {2}", line.Id, line.ProductId, line.ProductCode);
            }

            Console.WriteLine(string.Empty);
        }

        private static void ChoamTest()
        {
            Console.WriteLine("CHOAM");
            var repo = new Repository();
            var basket = repo.LoadData<Choam.ChoamBasket>();
            foreach (var line in basket.Lines)
            {
                Console.WriteLine("{0} - {1} - {2:C}", line.Id, line.ProductId, line.ProductPrice);
            }

            Console.WriteLine(string.Empty);
        }
    }
}
