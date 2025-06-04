namespace UnityEngine.Animations.Rigging;

public struct BoolProperty : IAnimatableProperty<Boolean>
{
	public PropertyStreamHandle value; //Field offset: 0x0

	public static BoolProperty Bind(Animator animator, Component component, string name) { }

	public static BoolProperty BindCustom(Animator animator, string property) { }

	public override bool Get(AnimationStream stream) { }

	public override void Set(AnimationStream stream, bool v) { }

}

