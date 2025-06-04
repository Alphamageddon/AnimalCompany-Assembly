namespace Fusion.CodeGen;

[PreserveInPlugin]
[WeaverGenerated]
internal struct ReaderWriter@UnityEngine_Vector3 : IElementReaderWriter<Vector3>
{
	[WeaverGenerated]
	public static IElementReaderWriter<Vector3> Instance; //Field offset: 0x0

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override int GetElementHashCode(Vector3 val) { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override int GetElementWordCount() { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[WeaverGenerated]
	public static IElementReaderWriter<Vector3> GetInstance() { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override Vector3 Read(Byte* data, int index) { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override Vector3 ReadRef(Byte* data, int index) { }

	[MethodImpl(MethodImplOptions::AggressiveInlining (256))]
	[PreserveInPlugin]
	[WeaverGenerated]
	public override void Write(Byte* data, int index, Vector3 val) { }

}

