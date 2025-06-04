namespace UnityEngine.Animations.Rigging;

public struct Vector3Property : IAnimatableProperty<Vector3>
{
	public PropertyStreamHandle x; //Field offset: 0x0
	public PropertyStreamHandle y; //Field offset: 0x10
	public PropertyStreamHandle z; //Field offset: 0x20

	public static Vector3Property Bind(Animator animator, Component component, string name) { }

	public static Vector3Property BindCustom(Animator animator, string name) { }

	public override Vector3 Get(AnimationStream stream) { }

	public override void Set(AnimationStream stream, Vector3 value) { }

}

