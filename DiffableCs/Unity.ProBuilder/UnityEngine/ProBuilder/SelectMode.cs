namespace UnityEngine.ProBuilder;

[Flags]
public enum SelectMode
{
	None = 0,
	Object = 1,
	Vertex = 2,
	Edge = 4,
	Face = 8,
	TextureFace = 16,
	TextureEdge = 32,
	TextureVertex = 64,
	InputTool = 128,
	Any = 65535,
}

