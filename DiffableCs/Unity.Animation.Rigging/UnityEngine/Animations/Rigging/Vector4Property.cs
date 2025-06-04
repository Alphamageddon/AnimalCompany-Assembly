namespace UnityEngine.Animations.Rigging;

public struct Vector4Property : IAnimatableProperty<Vector4>
{
	public PropertyStreamHandle x; //Field offset: 0x0
	public PropertyStreamHandle y; //Field offset: 0x10
	public PropertyStreamHandle z; //Field offset: 0x20
	public PropertyStreamHandle w; //Field offset: 0x30

	public static Vector4Property Bind(Animator animator, Component component, string name) { }

	public static Vector4Property BindCustom(Animator animator, string name) { }

	public override Vector4 Get(AnimationStream stream) { }

	public override void Set(AnimationStream stream, Vector4 value) { }

}

