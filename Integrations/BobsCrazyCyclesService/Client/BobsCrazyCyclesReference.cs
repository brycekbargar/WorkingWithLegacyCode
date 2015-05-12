//"Generated" Code

public namespace WorkingWithLegacyCode.Integrations.BobsCrazyCycles.Client
{
	public abstract class OrderRequest
	{
		public decimal Version { get; set; }
		public int Id { get; set; }
	}
	
	public abstract class OrderResponse
	{
		public int SaleNumber { get; set; }
	}
	
	public abstract class ListPriceRequest
	{
		public decimal Version { get; set; }
	}
	
	public abstract class ListPriceResponse
	{
		IList<KeyValuePair<int, decimal>> IdsAndPrices { get; set; }
	}
	
	public class OrderTricycleRequest : OrderRequest { }
	public class OrderTricycleResponse : OrderResponse { }
	public class ListTricyclePriceRequest : ListPriceRequest { }
	public class ListTricyclePriceResponse : ListPriceResponse { }
		
	public class OrderBicycleRequest : OrderRequest { }
	public class OrderBicycleResponse : OrderResponse { }
	public class ListBicyclePriceRequest : ListPriceRequest { }
	public class ListBicyclePriceResponse : ListPriceResponse { }
		
	public class OrderClownShoesRequest : OrderRequest { }
	public class OrderClownShoesResponse : OrderResponse { }
	public class ListClownShoesPriceRequest : ListPriceRequest { }
	public class ListClownShoesPriceResponse : ListPriceResponse { }
		
	public class ErrorResponse
	{
		public string Message { get; set; }
		public string Code { get; set; }
		public long UniqueId { get; set; }
	}
}