namespace Oculus.Platform.Models;

public class Error
{
	public readonly int Code; //Field offset: 0x10
	public readonly int HttpCode; //Field offset: 0x14
	public readonly string Message; //Field offset: 0x18

	public Error(int code, string message, int httpCode) { }

}

