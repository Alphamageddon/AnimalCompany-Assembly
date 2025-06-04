namespace System.Runtime.Serialization;

[ComVisible(True)]
[IsReadOnly]
public struct StreamingContext
{
	internal readonly object m_additionalContext; //Field offset: 0x0
	internal readonly StreamingContextStates m_state; //Field offset: 0x8

	public StreamingContextStates State
	{
		 get { } //Length: 8
	}

	public StreamingContext(StreamingContextStates state) { }

	public StreamingContext(StreamingContextStates state, object additional) { }

	public virtual bool Equals(object obj) { }

	public StreamingContextStates get_State() { }

	public virtual int GetHashCode() { }

}

