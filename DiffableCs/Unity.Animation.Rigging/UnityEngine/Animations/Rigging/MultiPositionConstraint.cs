namespace UnityEngine.Animations.Rigging;

[AddComponentMenu("Animation Rigging/Multi-Position Constraint")]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.2/manual/constraints/MultiPositionConstraint.html")]
public class MultiPositionConstraint : RigConstraint<MultiPositionConstraintJob, MultiPositionConstraintData, MultiPositionConstraintJobBinder`1<MultiPositionConstraintData>>
{

	public MultiPositionConstraint() { }

	protected virtual void OnValidate() { }

}

