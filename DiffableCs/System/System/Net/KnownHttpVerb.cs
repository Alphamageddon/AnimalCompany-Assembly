namespace System.Net;

internal class KnownHttpVerb
{
	private static ListDictionary NamedHeaders; //Field offset: 0x0
	internal static KnownHttpVerb Get; //Field offset: 0x8
	internal static KnownHttpVerb Connect; //Field offset: 0x10
	internal static KnownHttpVerb Head; //Field offset: 0x18
	internal static KnownHttpVerb Put; //Field offset: 0x20
	internal static KnownHttpVerb Post; //Field offset: 0x28
	internal static KnownHttpVerb MkCol; //Field offset: 0x30
	internal string Name; //Field offset: 0x10
	internal bool RequireContentBody; //Field offset: 0x18
	internal bool ContentBodyNotAllowed; //Field offset: 0x19
	internal bool ConnectRequest; //Field offset: 0x1A
	internal bool ExpectNoContentResponse; //Field offset: 0x1B

	private static KnownHttpVerb() { }

	internal KnownHttpVerb(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse) { }

	public static KnownHttpVerb Parse(string name) { }

}

