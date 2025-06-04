namespace UnityEngine.Animations.Rigging;

public struct Vector2Property : IAnimatableProperty<Vector2>
{
	public PropertyStreamHandle x; //Field offset: 0x0
	public PropertyStreamHandle y; //Field offset: 0x10

	public static Vector2Property Bind(Animator animator, Component component, string name) { }

	public static Vector2Property BindCustom(Animator animator, string name) { }

	public override Vector2 Get(AnimationStream stream) { }

	public override void Set(AnimationStream stream, Vector2 value) { }

}

