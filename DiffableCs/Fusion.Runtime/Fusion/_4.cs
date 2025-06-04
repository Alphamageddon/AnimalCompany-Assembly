namespace Fusion;

[NetworkStructWeaved(4)]
public struct _4 : INetworkStruct, IFixedStorage
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <Data>e__FixedBuffer
	{
		public uint FixedElementField; //Field offset: 0x0

	}

	public const int SIZE = 16; //Field offset: 0x0
	[FixedBuffer(typeof(uint, 4)]
	public <Data>e__FixedBuffer Data; //Field offset: 0x0
	private uint _data0; //Field offset: 0x0
	private uint _data1; //Field offset: 0x4
	private uint _data2; //Field offset: 0x8
	private uint _data3; //Field offset: 0xC

}

