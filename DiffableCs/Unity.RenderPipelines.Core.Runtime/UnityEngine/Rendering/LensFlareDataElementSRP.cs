namespace UnityEngine.Rendering;

public sealed class LensFlareDataElementSRP
{
	public bool visible; //Field offset: 0x10
	public float position; //Field offset: 0x14
	public Vector2 positionOffset; //Field offset: 0x18
	public float angularOffset; //Field offset: 0x20
	public Vector2 translationScale; //Field offset: 0x24
	[FormerlySerializedAs("localIntensity")]
	[Min(0)]
	[SerializeField]
	private float m_LocalIntensity; //Field offset: 0x2C
	public Texture lensFlareTexture; //Field offset: 0x30
	public float uniformScale; //Field offset: 0x38
	public Vector2 sizeXY; //Field offset: 0x3C
	public bool allowMultipleElement; //Field offset: 0x44
	[FormerlySerializedAs("count")]
	[Min(1)]
	[SerializeField]
	private int m_Count; //Field offset: 0x48
	public bool preserveAspectRatio; //Field offset: 0x4C
	public float rotation; //Field offset: 0x50
	public Color tint; //Field offset: 0x54
	public SRPLensFlareBlendMode blendMode; //Field offset: 0x64
	public bool autoRotate; //Field offset: 0x68
	public SRPLensFlareType flareType; //Field offset: 0x6C
	public bool modulateByLightColor; //Field offset: 0x70
	[SerializeField]
	private bool isFoldOpened; //Field offset: 0x71
	public SRPLensFlareDistribution distribution; //Field offset: 0x74
	public float lengthSpread; //Field offset: 0x78
	public AnimationCurve positionCurve; //Field offset: 0x80
	public AnimationCurve scaleCurve; //Field offset: 0x88
	public int seed; //Field offset: 0x90
	public Gradient colorGradient; //Field offset: 0x98
	[FormerlySerializedAs("intensityVariation")]
	[Range(0, 1)]
	[SerializeField]
	private float m_IntensityVariation; //Field offset: 0xA0
	public Vector2 positionVariation; //Field offset: 0xA4
	public float scaleVariation; //Field offset: 0xAC
	public float rotationVariation; //Field offset: 0xB0
	public bool enableRadialDistortion; //Field offset: 0xB4
	public Vector2 targetSizeDistortion; //Field offset: 0xB8
	public AnimationCurve distortionCurve; //Field offset: 0xC0
	public bool distortionRelativeToCenter; //Field offset: 0xC8
	[FormerlySerializedAs("fallOff")]
	[Range(0, 1)]
	[SerializeField]
	private float m_FallOff; //Field offset: 0xCC
	[FormerlySerializedAs("edgeOffset")]
	[Range(0, 1)]
	[SerializeField]
	private float m_EdgeOffset; //Field offset: 0xD0
	[FormerlySerializedAs("sideCount")]
	[Min(3)]
	[SerializeField]
	private int m_SideCount; //Field offset: 0xD4
	[FormerlySerializedAs("sdfRoundness")]
	[Range(0, 1)]
	[SerializeField]
	private float m_SdfRoundness; //Field offset: 0xD8
	public bool inverseSDF; //Field offset: 0xDC
	public float uniformAngle; //Field offset: 0xE0
	public AnimationCurve uniformAngleCurve; //Field offset: 0xE8

	public int count
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public float edgeOffset
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public float fallOff
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public float intensityVariation
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public float localIntensity
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public float sdfRoundness
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public int sideCount
	{
		 get { } //Length: 8
		 set { } //Length: 20
	}

	public LensFlareDataElementSRP() { }

	public int get_count() { }

	public float get_edgeOffset() { }

	public float get_fallOff() { }

	public float get_intensityVariation() { }

	public float get_localIntensity() { }

	public float get_sdfRoundness() { }

	public int get_sideCount() { }

	public void set_count(int value) { }

	public void set_edgeOffset(float value) { }

	public void set_fallOff(float value) { }

	public void set_intensityVariation(float value) { }

	public void set_localIntensity(float value) { }

	public void set_sdfRoundness(float value) { }

	public void set_sideCount(int value) { }

}

