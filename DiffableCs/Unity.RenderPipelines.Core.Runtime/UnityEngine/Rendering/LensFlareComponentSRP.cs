namespace UnityEngine.Rendering;

[AddComponentMenu("Rendering/Lens Flare (SRP)")]
[ExecuteAlways]
public sealed class LensFlareComponentSRP : MonoBehaviour
{
	private static float sCelestialAngularRadius; //Field offset: 0x0
	[SerializeField]
	private LensFlareDataSRP m_LensFlareData; //Field offset: 0x20
	[Min(0)]
	public float intensity; //Field offset: 0x28
	[Min(1E-05)]
	public float maxAttenuationDistance; //Field offset: 0x2C
	[Min(1E-05)]
	public float maxAttenuationScale; //Field offset: 0x30
	public AnimationCurve distanceAttenuationCurve; //Field offset: 0x38
	public AnimationCurve scaleByDistanceCurve; //Field offset: 0x40
	public bool attenuationByLightShape; //Field offset: 0x48
	public AnimationCurve radialScreenAttenuationCurve; //Field offset: 0x50
	public bool useOcclusion; //Field offset: 0x58
	[Min(0)]
	public float occlusionRadius; //Field offset: 0x5C
	public bool useBackgroundCloudOcclusion; //Field offset: 0x60
	[Range(1, 64)]
	public uint sampleCount; //Field offset: 0x64
	public float occlusionOffset; //Field offset: 0x68
	[Min(0)]
	public float scale; //Field offset: 0x6C
	public bool allowOffScreen; //Field offset: 0x70
	public bool volumetricCloudOcclusion; //Field offset: 0x71
	public TextureCurve occlusionRemapCurve; //Field offset: 0x78

	public LensFlareDataSRP lensFlareData
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private static LensFlareComponentSRP() { }

	public LensFlareComponentSRP() { }

	public float celestialProjectedOcclusionRadius(Camera mainCam) { }

	public LensFlareDataSRP get_lensFlareData() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnValidate() { }

	public void set_lensFlareData(LensFlareDataSRP value) { }

}

