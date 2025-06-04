namespace Nakama.Console;

public sealed class ApiResponseException : Exception
{
	[CompilerGenerated]
	private readonly long <StatusCode>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private readonly int <GrpcStatusCode>k__BackingField; //Field offset: 0x98

	public int GrpcStatusCode
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public long StatusCode
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public ApiResponseException(long statusCode, string content, int grpcCode) { }

	public ApiResponseException(string message, Exception e) { }

	public ApiResponseException(string content) { }

	[CompilerGenerated]
	public int get_GrpcStatusCode() { }

	[CompilerGenerated]
	public long get_StatusCode() { }

	public virtual string ToString() { }

}

