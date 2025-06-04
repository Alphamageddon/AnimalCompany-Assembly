namespace UnityEngine.Rendering.Universal;

[MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
public struct Light2DBlendStyle
{
	public struct BlendFactors
	{
		public float multiplicative; //Field offset: 0x0
		public float additive; //Field offset: 0x4

	}

	public enum BlendMode
	{
		Additive = 0,
		Multiply = 1,
		Subtractive = 2,
	}

	public struct MaskChannelFilter
	{
		[CompilerGenerated]
		private Vector4 <mask>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Vector4 <inverted>k__BackingField; //Field offset: 0x10

		public private Vector4 inverted
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 12
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public private Vector4 mask
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 12
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public MaskChannelFilter(Vector4 m, Vector4 i) { }

		[CompilerGenerated]
		[IsReadOnly]
		public Vector4 get_inverted() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Vector4 get_mask() { }

		[CompilerGenerated]
		private void set_inverted(Vector4 value) { }

		[CompilerGenerated]
		private void set_mask(Vector4 value) { }

	}

	public enum TextureChannel
	{
		None = 0,
		R = 1,
		G = 2,
		B = 3,
		A = 4,
		OneMinusR = 5,
		OneMinusG = 6,
		OneMinusB = 7,
		OneMinusA = 8,
	}

	public string name; //Field offset: 0x0
	[SerializeField]
	internal TextureChannel maskTextureChannel; //Field offset: 0x8
	[SerializeField]
	internal BlendMode blendMode; //Field offset: 0xC
	[CompilerGenerated]
	private bool <isDirty>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <hasRenderTarget>k__BackingField; //Field offset: 0x11
	internal int renderTargetHandleId; //Field offset: 0x14
	internal RTHandle renderTargetHandle; //Field offset: 0x18

	internal Vector2 blendFactors
	{
		internal get { } //Length: 52
	}

	internal bool hasRenderTarget
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	internal bool isDirty
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	internal MaskChannelFilter maskTextureChannelFilter
	{
		internal get { } //Length: 332
	}

	internal Vector2 get_blendFactors() { }

	[CompilerGenerated]
	[IsReadOnly]
	internal bool get_hasRenderTarget() { }

	[CompilerGenerated]
	[IsReadOnly]
	internal bool get_isDirty() { }

	internal MaskChannelFilter get_maskTextureChannelFilter() { }

	[CompilerGenerated]
	internal void set_hasRenderTarget(bool value) { }

	[CompilerGenerated]
	internal void set_isDirty(bool value) { }

}

