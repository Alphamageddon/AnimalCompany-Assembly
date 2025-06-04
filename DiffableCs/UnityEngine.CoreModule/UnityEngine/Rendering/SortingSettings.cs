namespace UnityEngine.Rendering;

public struct SortingSettings : IEquatable<SortingSettings>
{
	private Matrix4x4 m_WorldToCameraMatrix; //Field offset: 0x0
	private Vector3 m_CameraPosition; //Field offset: 0x40
	private Vector3 m_CustomAxis; //Field offset: 0x4C
	private SortingCriteria m_Criteria; //Field offset: 0x58
	private DistanceMetric m_DistanceMetric; //Field offset: 0x5C

	public SortingCriteria criteria
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Vector3 customAxis
	{
		 set { } //Length: 12
	}

	public DistanceMetric distanceMetric
	{
		 set { } //Length: 8
	}

	public SortingSettings(Camera camera) { }

	public override bool Equals(SortingSettings other) { }

	public virtual bool Equals(object obj) { }

	public SortingCriteria get_criteria() { }

	public virtual int GetHashCode() { }

	public void set_criteria(SortingCriteria value) { }

	public void set_customAxis(Vector3 value) { }

	public void set_distanceMetric(DistanceMetric value) { }

}

