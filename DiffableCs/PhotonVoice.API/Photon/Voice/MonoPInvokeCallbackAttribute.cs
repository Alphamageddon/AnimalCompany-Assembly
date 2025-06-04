namespace Photon.Voice;

public class MonoPInvokeCallbackAttribute : Attribute
{
	private Type type; //Field offset: 0x10

	public MonoPInvokeCallbackAttribute(Type t) { }

}

