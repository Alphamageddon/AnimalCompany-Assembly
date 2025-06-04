namespace Nakama.Ninja.WebSockets.Exceptions;

public class InvalidHttpResponseCodeException : Exception
{
	[CompilerGenerated]
	private string <ResponseCode>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private string <ResponseHeader>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private string <ResponseDetails>k__BackingField; //Field offset: 0xA0

	public private string ResponseCode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private string ResponseDetails
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private string ResponseHeader
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public InvalidHttpResponseCodeException() { }

	public InvalidHttpResponseCodeException(string message) { }

	public InvalidHttpResponseCodeException(string responseCode, string responseDetails, string responseHeader) { }

	public InvalidHttpResponseCodeException(string message, Exception inner) { }

	[CompilerGenerated]
	public string get_ResponseCode() { }

	[CompilerGenerated]
	public string get_ResponseDetails() { }

	[CompilerGenerated]
	public string get_ResponseHeader() { }

	[CompilerGenerated]
	private void set_ResponseCode(string value) { }

	[CompilerGenerated]
	private void set_ResponseDetails(string value) { }

	[CompilerGenerated]
	private void set_ResponseHeader(string value) { }

}

