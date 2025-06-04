namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
public struct HapticCapabilities : IEquatable<HapticCapabilities>
{
	private uint m_NumChannels; //Field offset: 0x0
	private bool m_SupportsImpulse; //Field offset: 0x4
	private bool m_SupportsBuffer; //Field offset: 0x5
	private uint m_BufferFrequencyHz; //Field offset: 0x8
	private uint m_BufferMaxSize; //Field offset: 0xC
	private uint m_BufferOptimalSize; //Field offset: 0x10

	public uint bufferFrequencyHz
	{
		 get { } //Length: 8
	}

	public uint bufferMaxSize
	{
		 get { } //Length: 8
	}

	public uint bufferOptimalSize
	{
		 get { } //Length: 8
	}

	public uint numChannels
	{
		 get { } //Length: 8
	}

	public bool supportsBuffer
	{
		 get { } //Length: 8
	}

	public bool supportsImpulse
	{
		 get { } //Length: 8
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(HapticCapabilities other) { }

	public uint get_bufferFrequencyHz() { }

	public uint get_bufferMaxSize() { }

	public uint get_bufferOptimalSize() { }

	public uint get_numChannels() { }

	public bool get_supportsBuffer() { }

	public bool get_supportsImpulse() { }

	public virtual int GetHashCode() { }

}

