namespace Fusion;

[NetworkStructWeaved(16)]
public struct _16 : INetworkStruct, IFixedStorage
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <Data>e__FixedBuffer
	{
		public uint FixedElementField; //Field offset: 0x0

	}

	public const int SIZE = 64; //Field offset: 0x0
	[FixedBuffer(typeof(uint, 16)]
	public <Data>e__FixedBuffer Data; //Field offset: 0x0
	private uint _data0; //Field offset: 0x0
	private uint _data1; //Field offset: 0x4
	private uint _data2; //Field offset: 0x8
	private uint _data3; //Field offset: 0xC
	private uint _data4; //Field offset: 0x10
	private uint _data5; //Field offset: 0x14
	private uint _data6; //Field offset: 0x18
	private uint _data7; //Field offset: 0x1C
	private uint _data8; //Field offset: 0x20
	private uint _data9; //Field offset: 0x24
	private uint _data10; //Field offset: 0x28
	private uint _data11; //Field offset: 0x2C
	private uint _data12; //Field offset: 0x30
	private uint _data13; //Field offset: 0x34
	private uint _data14; //Field offset: 0x38
	private uint _data15; //Field offset: 0x3C

}

