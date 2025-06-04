namespace UnityEngine.Animations.Rigging;

[AddComponentMenu("Animation Rigging/Multi-Aim Constraint")]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.2/manual/constraints/MultiAimConstraint.html")]
public class MultiAimConstraint : RigConstraint<MultiAimConstraintJob, MultiAimConstraintData, MultiAimConstraintJobBinder`1<MultiAimConstraintData>>
{

	public MultiAimConstraint() { }

	protected virtual void OnValidate() { }

}

