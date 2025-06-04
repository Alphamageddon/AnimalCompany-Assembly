namespace POpusCodec;

public class OpusException : Exception
{
	private OpusStatusCode _statusCode; //Field offset: 0x8C

	public OpusStatusCode StatusCode
	{
		 get { } //Length: 8
	}

	public OpusException(OpusStatusCode statusCode, string message) { }

	public OpusStatusCode get_StatusCode() { }

}

