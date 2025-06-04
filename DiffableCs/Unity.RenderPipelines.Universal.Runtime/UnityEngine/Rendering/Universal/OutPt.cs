namespace UnityEngine.Rendering.Universal;

internal class OutPt
{
	internal int Idx; //Field offset: 0x10
	internal IntPoint Pt; //Field offset: 0x18
	internal OutPt Next; //Field offset: 0x48
	internal OutPt Prev; //Field offset: 0x50

	public OutPt() { }

}

