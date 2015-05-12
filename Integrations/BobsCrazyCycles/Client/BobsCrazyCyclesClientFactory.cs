namespace WorkingWithLegacyCode.Integrations.BobsCrazyCycles.Client
{
	public class BobsCrazyCyclesClientFactory : IBobsCrazyCyclesClientFactory
	{
		private readonly BobsCrazyCyclesSettings _settings;
		
		public BobsCrazyCyclesClientFactory(BobsCrazyCyclesSettings settings)
		{
			_settings = settings;
		}
		
		public IBobsCrazyCyclesClient Create()
		{
			var credentials = new Credentials(_settings.Username, _settings.Password);
			var serviceReference = new ServiceReference(credentials, _settings.Endpoint);
			
			return new BobsCrazyCyclesClient(serviceReference);
		}
	}
}
