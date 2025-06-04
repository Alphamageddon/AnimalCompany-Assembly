namespace Fusion;

[NetworkStructWeaved(2)]
public struct _2 : INetworkStruct, IFixedStorage
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <Data>e__FixedBuffer
	{
		public uint FixedElementField; //Field offset: 0x0

	}

	public const int SIZE = 8; //Field offset: 0x0
	[FixedBuffer(typeof(uint, 2)]
	public <Data>e__FixedBuffer Data; //Field offset: 0x0
	private uint _data0; //Field offset: 0x0
	private uint _data1; //Field offset: 0x4

}

