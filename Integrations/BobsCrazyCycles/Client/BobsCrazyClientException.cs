public namespace WorkingWithLegacyCode.Integrations.BobsCrazyCycles.Client
{
	public partial class ErrorResponse : Exception
	{
		public ErrorResponse() : base(Message) { }
	}
}