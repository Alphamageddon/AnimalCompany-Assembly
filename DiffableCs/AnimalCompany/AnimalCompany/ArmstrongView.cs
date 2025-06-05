namespace AnimalCompany;

public class ArmstrongView : MobView
{
	private bool _isHeadMoving; //Field offset: 0x85
	private float _headMovingSpeed; //Field offset: 0x88
	private Vector3 _headLookAtLocalPositionCached; //Field offset: 0x8C

	public ArmstrongView() { }

	protected virtual void Awake() { }

	public void SetHeadLookAtTarget(Vector3 target, Vector3 viewPoint) { }

	public void SetHeadMoving(bool isHeadMoving, float speed = 0.2) { }

	protected virtual void Update() { }

}

