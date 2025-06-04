namespace UnityEngine.U2D;

[Extension]
[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
public static class SpriteDataAccessExtensions
{

	private static void CheckAttributeTypeMatchesAndThrow(VertexAttribute channel) { }

	private static SpriteChannelInfo GetChannelInfo(Sprite sprite, VertexAttribute channel) { }

	private static void GetChannelInfo_Injected(Sprite sprite, VertexAttribute channel, out SpriteChannelInfo ret) { }

	[Extension]
	public static NativeArray<UInt16> GetIndices(Sprite sprite) { }

	private static SpriteChannelInfo GetIndicesInfo(Sprite sprite) { }

	private static void GetIndicesInfo_Injected(Sprite sprite, out SpriteChannelInfo ret) { }

	[Extension]
	public static NativeSlice<T> GetVertexAttribute(Sprite sprite, VertexAttribute channel) { }

}

