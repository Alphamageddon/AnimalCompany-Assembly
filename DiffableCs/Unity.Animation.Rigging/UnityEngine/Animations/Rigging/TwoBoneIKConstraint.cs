namespace UnityEngine.Animations.Rigging;

[AddComponentMenu("Animation Rigging/Two Bone IK Constraint")]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.2/manual/constraints/TwoBoneIKConstraint.html")]
public class TwoBoneIKConstraint : RigConstraint<TwoBoneIKConstraintJob, TwoBoneIKConstraintData, TwoBoneIKConstraintJobBinder`1<TwoBoneIKConstraintData>>
{

	public TwoBoneIKConstraint() { }

	protected virtual void OnValidate() { }

}

