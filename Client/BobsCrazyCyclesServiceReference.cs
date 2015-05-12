//"Generated" Code

public namespace WorkingWithLegacyCode.Integrations.BobsCrazyCycles.Client
{
	public class Request
	{
		public decimal Version { get; set;}
		public object Request { get; set;}	
	}
	
	public class Response
	{
		public string Ack { get; set; }
		public object Response { get; set; }
	}
	
	public class ServiceReference : WebService // I think WebService?
	{
		public Response Send(Request request)
		{
			// Some sort of SOAP Witchcraft
		}
	}
}
