namespace UnityEngine;

[NativeHeader("Runtime/Scripting/TextAsset.h")]
public class TextAsset : object
{
	private static class EncodingUtility
	{
		internal static readonly KeyValuePair<Byte[], Encoding>[] encodingLookup; //Field offset: 0x0
		internal static readonly Encoding targetEncoding; //Field offset: 0x8

		private static EncodingUtility() { }

	}


	public Byte[] bytes
	{
		 get { } //Length: 60
	}

	public string text
	{
		 get { } //Length: 144
	}

	internal static string DecodeString(Byte[] bytes) { }

	public Byte[] get_bytes() { }

	public string get_text() { }

	public NativeArray<T> GetData() { }

	private IntPtr GetDataPtr() { }

	private long GetDataSize() { }

	public virtual string ToString() { }

}

