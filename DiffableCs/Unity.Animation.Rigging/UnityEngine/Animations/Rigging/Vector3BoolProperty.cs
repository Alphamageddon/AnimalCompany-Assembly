namespace UnityEngine.Animations.Rigging;

public struct Vector3BoolProperty : IAnimatableProperty<Vector3Bool>
{
	public PropertyStreamHandle x; //Field offset: 0x0
	public PropertyStreamHandle y; //Field offset: 0x10
	public PropertyStreamHandle z; //Field offset: 0x20

	public static Vector3BoolProperty Bind(Animator animator, Component component, string name) { }

	public static Vector3BoolProperty BindCustom(Animator animator, string name) { }

	public override Vector3Bool Get(AnimationStream stream) { }

	public override void Set(AnimationStream stream, Vector3Bool value) { }

}

