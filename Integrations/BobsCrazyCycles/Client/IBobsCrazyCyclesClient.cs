public namespace WorkingWithLegacyCode.Integrations.BobsCrazyCycles.Client
{
	public interface IBobsCrazyCyclesClientFactory
	{
		IBobsCrazyCyclesClient Create();
	}

	public interface IBobsCrazyCyclesClient : IDisposable
	{
		IBobsCrazyCyclesClientWithRequest Make<TRequest>(TRequest request);
	}
	
	public interface IBobsCrazyCyclesClientWithRequest
	{
		TResponse AndGet<TResponse>();
	}
}