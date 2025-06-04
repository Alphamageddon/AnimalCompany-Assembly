namespace UnityEngine.Animations.Rigging;

[AddComponentMenu("Animation Rigging/Multi-Rotation Constraint")]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.2/manual/constraints/MultiRotationConstraint.html")]
public class MultiRotationConstraint : RigConstraint<MultiRotationConstraintJob, MultiRotationConstraintData, MultiRotationConstraintJobBinder`1<MultiRotationConstraintData>>
{

	public MultiRotationConstraint() { }

	protected virtual void OnValidate() { }

}

