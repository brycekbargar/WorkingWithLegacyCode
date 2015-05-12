//"Generated" Code

public namespace WorkingWithLegacyCode.Integrations.BobsCrazyCycles.Client
{
	public class Request
	{
		public object Request { get; set;}	
	}
	
	public class Response
	{
		public string Ack { get; set; }
		public object Response { get; set; }
	}
	
	public class ServiceReference : MagicSOAPService
	{
		public ServiceReference(Credentials credentials, string endpoint) : base(credentials, endpoint)
		{
			
		}
		
		public Response Send(Request request)
		{
			// Some sort of SOAP Witchcraft
		}
	}
}
