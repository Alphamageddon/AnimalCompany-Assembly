namespace UnityEngine.Animations.Rigging;

public struct FloatProperty : IAnimatableProperty<Single>
{
	public PropertyStreamHandle value; //Field offset: 0x0

	public static FloatProperty Bind(Animator animator, Component component, string name) { }

	public static FloatProperty BindCustom(Animator animator, string property) { }

	public override float Get(AnimationStream stream) { }

	public override void Set(AnimationStream stream, float v) { }

}

