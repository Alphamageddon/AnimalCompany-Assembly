namespace UnityEngine.Animations.Rigging;

[AddComponentMenu("Animation Rigging/Blend Constraint")]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.2/manual/constraints/BlendConstraint.html")]
public class BlendConstraint : RigConstraint<BlendConstraintJob, BlendConstraintData, BlendConstraintJobBinder`1<BlendConstraintData>>
{

	public BlendConstraint() { }

	protected virtual void OnValidate() { }

}

