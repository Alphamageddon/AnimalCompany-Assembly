namespace UnityEngine.InputSystem.XR.Haptics;

public struct HapticCapabilities
{
	[CompilerGenerated]
	private uint <numChannels>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private uint <frequencyHz>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private uint <maxBufferSize>k__BackingField; //Field offset: 0x8

	public private uint frequencyHz
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private uint maxBufferSize
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private uint numChannels
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public HapticCapabilities(uint numChannels, uint frequencyHz, uint maxBufferSize) { }

	[CompilerGenerated]
	[IsReadOnly]
	public uint get_frequencyHz() { }

	[CompilerGenerated]
	[IsReadOnly]
	public uint get_maxBufferSize() { }

	[CompilerGenerated]
	[IsReadOnly]
	public uint get_numChannels() { }

	[CompilerGenerated]
	private void set_frequencyHz(uint value) { }

	[CompilerGenerated]
	private void set_maxBufferSize(uint value) { }

	[CompilerGenerated]
	private void set_numChannels(uint value) { }

}

