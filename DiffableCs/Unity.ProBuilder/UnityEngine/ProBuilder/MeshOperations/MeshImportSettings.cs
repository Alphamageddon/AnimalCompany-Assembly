namespace UnityEngine.ProBuilder.MeshOperations;

public sealed class MeshImportSettings
{
	[SerializeField]
	private bool m_Quads; //Field offset: 0x10
	[SerializeField]
	private bool m_Smoothing; //Field offset: 0x11
	[SerializeField]
	private float m_SmoothingThreshold; //Field offset: 0x14

	public bool quads
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool smoothing
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float smoothingAngle
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public MeshImportSettings() { }

	public bool get_quads() { }

	public bool get_smoothing() { }

	public float get_smoothingAngle() { }

	public void set_quads(bool value) { }

	public void set_smoothing(bool value) { }

	public void set_smoothingAngle(float value) { }

	public virtual string ToString() { }

}

