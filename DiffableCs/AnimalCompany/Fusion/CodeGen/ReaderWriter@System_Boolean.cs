namespace Fusion.CodeGen;

[PreserveInPlugin]
[WeaverGenerated]
internal struct ReaderWriter@System_Boolean : IElementReaderWriter<Boolean>
{
	[WeaverGenerated]
	public static IElementReaderWriter<Boolean> Instance; //Field offset: 0x0

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override int GetElementHashCode(bool val) { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override int GetElementWordCount() { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[WeaverGenerated]
	public static IElementReaderWriter<Boolean> GetInstance() { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override bool Read(Byte* data, int index) { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override bool ReadRef(Byte* data, int index) { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override void Write(Byte* data, int index, bool val) { }

}

