namespace UnityEngine.Animations.Rigging;

[AddComponentMenu("Animation Rigging/Multi-Parent Constraint")]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.2/manual/constraints/MultiParentConstraint.html")]
public class MultiParentConstraint : RigConstraint<MultiParentConstraintJob, MultiParentConstraintData, MultiParentConstraintJobBinder`1<MultiParentConstraintData>>
{

	public MultiParentConstraint() { }

	protected virtual void OnValidate() { }

}

