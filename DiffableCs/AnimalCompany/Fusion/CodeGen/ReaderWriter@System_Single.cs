namespace Fusion.CodeGen;

[PreserveInPlugin]
[WeaverGenerated]
internal struct ReaderWriter@System_Single : IElementReaderWriter<Single>
{
	[WeaverGenerated]
	public static IElementReaderWriter<Single> Instance; //Field offset: 0x0

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override int GetElementHashCode(float val) { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override int GetElementWordCount() { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[WeaverGenerated]
	public static IElementReaderWriter<Single> GetInstance() { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override float Read(Byte* data, int index) { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override float ReadRef(Byte* data, int index) { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override void Write(Byte* data, int index, float val) { }

}

