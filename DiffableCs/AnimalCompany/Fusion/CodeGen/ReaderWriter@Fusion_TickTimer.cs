namespace Fusion.CodeGen;

[PreserveInPlugin]
[WeaverGenerated]
internal struct ReaderWriter@Fusion_TickTimer : IElementReaderWriter<TickTimer>
{
	[WeaverGenerated]
	public static IElementReaderWriter<TickTimer> Instance; //Field offset: 0x0

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override int GetElementHashCode(TickTimer val) { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override int GetElementWordCount() { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[WeaverGenerated]
	public static IElementReaderWriter<TickTimer> GetInstance() { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override TickTimer Read(Byte* data, int index) { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override TickTimer ReadRef(Byte* data, int index) { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override void Write(Byte* data, int index, TickTimer val) { }

}

