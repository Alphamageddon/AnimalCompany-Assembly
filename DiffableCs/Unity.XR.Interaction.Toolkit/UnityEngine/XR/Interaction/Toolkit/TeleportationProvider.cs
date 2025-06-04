namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Locomotion/Teleportation Provider", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.TeleportationProvider.html")]
public class TeleportationProvider : LocomotionProvider
{
	[CompilerGenerated]
	private TeleportRequest <currentRequest>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <validRequest>k__BackingField; //Field offset: 0x6C
	[SerializeField]
	[Tooltip("The time (in seconds) to delay the teleportation once it is activated.")]
	private float m_DelayTime; //Field offset: 0x70
	private bool m_HasExclusiveLocomotion; //Field offset: 0x74
	private float m_TimeStarted; //Field offset: 0x78

	protected TeleportRequest currentRequest
	{
		[CompilerGenerated]
		 get { } //Length: 24
		[CompilerGenerated]
		 set { } //Length: 24
	}

	public float delayTime
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected bool validRequest
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public TeleportationProvider() { }

	protected virtual void Awake() { }

	[CompilerGenerated]
	protected TeleportRequest get_currentRequest() { }

	public float get_delayTime() { }

	[CompilerGenerated]
	protected bool get_validRequest() { }

	public override bool QueueTeleportRequest(TeleportRequest teleportRequest) { }

	[CompilerGenerated]
	protected void set_currentRequest(TeleportRequest value) { }

	public void set_delayTime(float value) { }

	[CompilerGenerated]
	protected void set_validRequest(bool value) { }

	protected override void Update() { }

}

