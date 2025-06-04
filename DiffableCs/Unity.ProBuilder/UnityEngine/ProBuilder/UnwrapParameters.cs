namespace UnityEngine.ProBuilder;

public sealed class UnwrapParameters
{
	internal const float k_HardAngle = 88; //Field offset: 0x0
	internal const float k_PackMargin = 20; //Field offset: 0x0
	internal const float k_AngleError = 8; //Field offset: 0x0
	internal const float k_AreaError = 15; //Field offset: 0x0
	[FormerlySerializedAs("hardAngle")]
	[Range(1, 180)]
	[SerializeField]
	[Tooltip("Angle between neighbor triangles that will generate seam.")]
	private float m_HardAngle; //Field offset: 0x10
	[FormerlySerializedAs("packMargin")]
	[Range(1, 64)]
	[SerializeField]
	[Tooltip("Measured in pixels, assuming mesh will cover an entire 1024x1024 lightmap.")]
	private float m_PackMargin; //Field offset: 0x14
	[FormerlySerializedAs("angleError")]
	[Range(1, 75)]
	[SerializeField]
	[Tooltip("Measured in percents. Angle error measures deviation of UV angles from geometry angles. Area error measures deviation of UV triangles area from geometry triangles if they were uniformly scaled.")]
	private float m_AngleError; //Field offset: 0x18
	[FormerlySerializedAs("areaError")]
	[Range(1, 75)]
	[SerializeField]
	private float m_AreaError; //Field offset: 0x1C

	public float angleError
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float areaError
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float hardAngle
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float packMargin
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public UnwrapParameters() { }

	public UnwrapParameters(UnwrapParameters other) { }

	public float get_angleError() { }

	public float get_areaError() { }

	public float get_hardAngle() { }

	public float get_packMargin() { }

	public void Reset() { }

	public void set_angleError(float value) { }

	public void set_areaError(float value) { }

	public void set_hardAngle(float value) { }

	public void set_packMargin(float value) { }

	public virtual string ToString() { }

}

