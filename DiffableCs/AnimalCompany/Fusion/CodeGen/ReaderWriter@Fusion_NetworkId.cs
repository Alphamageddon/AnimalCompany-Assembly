namespace Fusion.CodeGen;

[PreserveInPlugin]
[WeaverGenerated]
internal struct ReaderWriter@Fusion_NetworkId : IElementReaderWriter<NetworkId>
{
	[WeaverGenerated]
	public static IElementReaderWriter<NetworkId> Instance; //Field offset: 0x0

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override int GetElementHashCode(NetworkId val) { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override int GetElementWordCount() { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[WeaverGenerated]
	public static IElementReaderWriter<NetworkId> GetInstance() { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override NetworkId Read(Byte* data, int index) { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override NetworkId ReadRef(Byte* data, int index) { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override void Write(Byte* data, int index, NetworkId val) { }

}

