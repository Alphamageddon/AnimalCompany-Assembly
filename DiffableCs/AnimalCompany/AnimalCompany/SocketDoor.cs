namespace AnimalCompany;

[NetworkBehaviourWeaved(0)]
public class SocketDoor : NetworkBehaviour
{
	public Rigidbody doorRB; //Field offset: 0x80
	public AudioSource creakingAudio; //Field offset: 0x88
	public RandomSFX slamSound; //Field offset: 0x90
	private Vector2 creakVelocityLerp; //Field offset: 0x98
	private float lastFrameAngularVel; //Field offset: 0xA0

	public SocketDoor() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	private void Update() { }

}

