namespace UnityEngine.Rendering;

public sealed class ProbeReferenceVolumeProfile : ScriptableObject
{
	public enum Version
	{
		Initial = 0,
	}

	[SerializeField]
	private Version version; //Field offset: 0x18
	[SerializeField]
	internal bool freezePlacement; //Field offset: 0x1C
	[Range(2, 5)]
	public int simplificationLevels; //Field offset: 0x20
	[Min(0.1)]
	public float minDistanceBetweenProbes; //Field offset: 0x24
	public LayerMask renderersLayerMask; //Field offset: 0x28
	[Min(0)]
	public float minRendererVolumeSize; //Field offset: 0x2C

	public int cellSizeInBricks
	{
		 get { } //Length: 52
	}

	public float cellSizeInMeters
	{
		 get { } //Length: 100
	}

	public int maxSubdivision
	{
		 get { } //Length: 12
	}

	public float minBrickSize
	{
		 get { } //Length: 28
	}

	public ProbeReferenceVolumeProfile() { }

	public int get_cellSizeInBricks() { }

	public float get_cellSizeInMeters() { }

	public int get_maxSubdivision() { }

	public float get_minBrickSize() { }

	public bool IsEquivalent(ProbeReferenceVolumeProfile otherProfile) { }

	private void OnEnable() { }

}

