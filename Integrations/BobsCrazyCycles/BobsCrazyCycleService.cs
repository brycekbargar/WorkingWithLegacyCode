namespace WorkingWithLegacyCode.Integrations.BobsCrazyCyclesService
{
    public class BobsCrazyCyclesService : IBobsCrazyCyclesService
    {
        private readonly IBobsCrazyCyclesCLientFactory _clientFactory;
        
        public BobsCrazyCyclesService(IBobsCrazyCyclesCLientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        
        PurchaseBicycleResponse BuyACheapBike()
        {
            try
            {
                using(var client = _clientFactory.Create())
                {
                    var bicyclesForSale = 
                        client
                            .Make(new ListBicyclePriceRequest
                            {
                                Version = 3.14M
                            })
                            .AndGet<ListBicyclePriceResponse>();
                        
                    var cheapestId = 
                        bicyclesForSale
                            .IdsAndPrices
                            .OrderBy(x => x.Value)
                            .Select(x => x.Key)
                            .FirstOrDefault();
                        
                    return
                        client
                            .Make(new PurchaseBicycleRequest
                            {
                                Version = 777M,
                                Id = cheapestId
                            })
                            .AndGet<PurchaseBicycleResponse>(); 
                }
            }
            catch(ErrorResponse)
            {
                // Do something because this response object is in our domain
                // Also it's pretty easy to the entire response because we have the whole thing!
            }
        }
    }
}
