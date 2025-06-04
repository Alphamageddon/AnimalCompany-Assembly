namespace UnityEngine.Rendering.Universal;

internal class TEdge
{
	internal IntPoint Bot; //Field offset: 0x10
	internal IntPoint Curr; //Field offset: 0x40
	internal IntPoint Top; //Field offset: 0x70
	internal IntPoint Delta; //Field offset: 0xA0
	internal double Dx; //Field offset: 0xD0
	internal PolyType PolyTyp; //Field offset: 0xD8
	internal EdgeSide Side; //Field offset: 0xDC
	internal int WindDelta; //Field offset: 0xE0
	internal int WindCnt; //Field offset: 0xE4
	internal int WindCnt2; //Field offset: 0xE8
	internal int OutIdx; //Field offset: 0xEC
	internal TEdge Next; //Field offset: 0xF0
	internal TEdge Prev; //Field offset: 0xF8
	internal TEdge NextInLML; //Field offset: 0x100
	internal TEdge NextInAEL; //Field offset: 0x108
	internal TEdge PrevInAEL; //Field offset: 0x110
	internal TEdge NextInSEL; //Field offset: 0x118
	internal TEdge PrevInSEL; //Field offset: 0x120

	public TEdge() { }

}

