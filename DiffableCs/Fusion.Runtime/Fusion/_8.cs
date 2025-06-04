namespace Fusion;

[NetworkStructWeaved(8)]
public struct _8 : INetworkStruct, IFixedStorage
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <Data>e__FixedBuffer
	{
		public uint FixedElementField; //Field offset: 0x0

	}

	public const int SIZE = 32; //Field offset: 0x0
	[FixedBuffer(typeof(uint, 8)]
	public <Data>e__FixedBuffer Data; //Field offset: 0x0
	private uint _data0; //Field offset: 0x0
	private uint _data1; //Field offset: 0x4
	private uint _data2; //Field offset: 0x8
	private uint _data3; //Field offset: 0xC
	private uint _data4; //Field offset: 0x10
	private uint _data5; //Field offset: 0x14
	private uint _data6; //Field offset: 0x18
	private uint _data7; //Field offset: 0x1C

}

