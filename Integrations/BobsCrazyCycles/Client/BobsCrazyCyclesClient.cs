public namespace WorkingWithLegacyCode.Integrations.BobsCrazyCycles.Client
{
	public class BobsCrazyCyclesClient : IBobsCrazyCyclesClient, IBobsCrazyCyclesClientWithRequest, IDisposable
	{
		private object Request { get; set; }
		private readonly ServiceReference _serviceReference;
		
		public BobsCrazyCyclesClient(ServiceReference serviceReference)
		{
			_serviceReference = serviceReference;
		}
		
		IBobsCrazyCyclesClientWithRequest Make<TRequest>(TRequest request)
		{
			Request = request;
			return this;
		}
		
		public TResponse AndGetResponse<TResponse>()
		{
			
		};
		
		public void Dispose()
    	{
        	Dispose(true);
        	GC.SuppressFinalize(this);
    	}
    
    	// The bulk of the clean-up code is implemented in Dispose(bool)
    	protected virtual void Dispose(bool disposing)
    	{
        	if (disposing) 
        	{
            	// free managed resources
            	if (_serviceReference != null)
            	{
					_serviceReference.DoALittleDance();
                	_serviceReference.Close();
            	}
        	}
        	// free native resources if there are any.
		}
	}
}