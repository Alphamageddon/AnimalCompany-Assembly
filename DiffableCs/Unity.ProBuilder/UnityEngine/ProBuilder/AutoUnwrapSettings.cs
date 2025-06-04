namespace UnityEngine.ProBuilder;

public struct AutoUnwrapSettings
{
	internal enum Anchor
	{
		UpperLeft = 0,
		UpperCenter = 1,
		UpperRight = 2,
		MiddleLeft = 3,
		MiddleCenter = 4,
		MiddleRight = 5,
		LowerLeft = 6,
		LowerCenter = 7,
		LowerRight = 8,
		None = 9,
	}

	internal enum Fill
	{
		Fit = 0,
		Tile = 1,
		Stretch = 2,
	}

	[FormerlySerializedAs("useWorldSpace")]
	[SerializeField]
	private bool m_UseWorldSpace; //Field offset: 0x0
	[FormerlySerializedAs("flipU")]
	[SerializeField]
	private bool m_FlipU; //Field offset: 0x1
	[FormerlySerializedAs("flipV")]
	[SerializeField]
	private bool m_FlipV; //Field offset: 0x2
	[FormerlySerializedAs("swapUV")]
	[SerializeField]
	private bool m_SwapUV; //Field offset: 0x3
	[FormerlySerializedAs("fill")]
	[SerializeField]
	private Fill m_Fill; //Field offset: 0x4
	[FormerlySerializedAs("scale")]
	[SerializeField]
	private Vector2 m_Scale; //Field offset: 0x8
	[FormerlySerializedAs("offset")]
	[SerializeField]
	private Vector2 m_Offset; //Field offset: 0x10
	[FormerlySerializedAs("rotation")]
	[SerializeField]
	private float m_Rotation; //Field offset: 0x18
	[FormerlySerializedAs("anchor")]
	[SerializeField]
	private Anchor m_Anchor; //Field offset: 0x1C

	public Anchor anchor
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public static AutoUnwrapSettings defaultAutoUnwrapSettings
	{
		 get { } //Length: 24
	}

	public Fill fill
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public static AutoUnwrapSettings fit
	{
		 get { } //Length: 24
	}

	public bool flipU
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool flipV
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Vector2 offset
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float rotation
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Vector2 scale
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public static AutoUnwrapSettings stretch
	{
		 get { } //Length: 24
	}

	public bool swapUV
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public static AutoUnwrapSettings tile
	{
		 get { } //Length: 24
	}

	public bool useWorldSpace
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public AutoUnwrapSettings(AutoUnwrapSettings unwrapSettings) { }

	public Anchor get_anchor() { }

	public static AutoUnwrapSettings get_defaultAutoUnwrapSettings() { }

	public Fill get_fill() { }

	public static AutoUnwrapSettings get_fit() { }

	public bool get_flipU() { }

	public bool get_flipV() { }

	public Vector2 get_offset() { }

	public float get_rotation() { }

	public Vector2 get_scale() { }

	public static AutoUnwrapSettings get_stretch() { }

	public bool get_swapUV() { }

	public static AutoUnwrapSettings get_tile() { }

	public bool get_useWorldSpace() { }

	public void Reset() { }

	public void set_anchor(Anchor value) { }

	public void set_fill(Fill value) { }

	public void set_flipU(bool value) { }

	public void set_flipV(bool value) { }

	public void set_offset(Vector2 value) { }

	public void set_rotation(float value) { }

	public void set_scale(Vector2 value) { }

	public void set_swapUV(bool value) { }

	public void set_useWorldSpace(bool value) { }

	public virtual string ToString() { }

}

