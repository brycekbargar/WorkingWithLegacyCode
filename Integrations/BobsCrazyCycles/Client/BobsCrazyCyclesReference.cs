//"Generated" Code

namespace WorkingWithLegacyCode.Integrations.BobsCrazyCycles.Client
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
	
	public partial class OrderTricycleRequest : OrderRequest { }
	public partial class OrderTricycleResponse : OrderResponse { }
	public partial class ListTricyclePriceRequest : ListPriceRequest { }
	public partial class ListTricyclePriceResponse : ListPriceResponse { }
		
	public partial class OrderBicycleRequest : OrderRequest { }
	public partial class OrderBicycleResponse : OrderResponse { }
	public partial class ListBicyclePriceRequest : ListPriceRequest { }
	public partial class ListBicyclePriceResponse : ListPriceResponse { }
		
	public partial class OrderClownShoesRequest : OrderRequest { }
	public partial class OrderClownShoesResponse : OrderResponse { }
	public partial class ListClownShoesPriceRequest : ListPriceRequest { }
	public partial class ListClownShoesPriceResponse : ListPriceResponse { }
		
	public partial class ErrorResponse
	{
		public string Message { get; set; }
		public string Code { get; set; }
		public long UniqueId { get; set; }
	}
}
