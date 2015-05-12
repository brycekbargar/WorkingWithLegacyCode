namespace WorkingWithLegacyCode
{
    public class Program
    {
        static void Main() 
        {
            var container = new DIContainer().ThatGetsInitializedSomewhere();
            
            var service = container.Get<IBobsCrazyCycleService>();
            
            var sale = service.BuyACheapBike();
            
            Console.WriteLine(String.Format(@"Congrats! You bought the cheapest bike! Your reference number is {0}", sale.SaleNumber));
        }
    }
}
