namespace System.Runtime.CompilerServices;

public sealed class RuntimeWrappedException : Exception
{
	private object _wrappedException; //Field offset: 0x90

	public RuntimeWrappedException(object thrownObject) { }

	private RuntimeWrappedException(SerializationInfo info, StreamingContext context) { }

	internal RuntimeWrappedException() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

