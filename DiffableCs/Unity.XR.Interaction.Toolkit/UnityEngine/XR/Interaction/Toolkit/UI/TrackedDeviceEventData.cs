namespace UnityEngine.XR.Interaction.Toolkit.UI;

public class TrackedDeviceEventData : PointerEventData
{
	[CompilerGenerated]
	private List<Vector3> <rayPoints>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private int <rayHitIndex>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private LayerMask <layerMask>k__BackingField; //Field offset: 0x18C
	[CompilerGenerated]
	private Vector3 <pressWorldPosition>k__BackingField; //Field offset: 0x190

	public IUIInteractor interactor
	{
		 get { } //Length: 220
	}

	public LayerMask layerMask
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	internal Vector3 pressWorldPosition
	{
		[CompilerGenerated]
		internal get { } //Length: 16
		[CompilerGenerated]
		internal set { } //Length: 16
	}

	public int rayHitIndex
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public List<Vector3> rayPoints
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public TrackedDeviceEventData(EventSystem eventSystem) { }

	public IUIInteractor get_interactor() { }

	[CompilerGenerated]
	public LayerMask get_layerMask() { }

	[CompilerGenerated]
	internal Vector3 get_pressWorldPosition() { }

	[CompilerGenerated]
	public int get_rayHitIndex() { }

	[CompilerGenerated]
	public List<Vector3> get_rayPoints() { }

	[CompilerGenerated]
	public void set_layerMask(LayerMask value) { }

	[CompilerGenerated]
	internal void set_pressWorldPosition(Vector3 value) { }

	[CompilerGenerated]
	public void set_rayHitIndex(int value) { }

	[CompilerGenerated]
	public void set_rayPoints(List<Vector3> value) { }

}

