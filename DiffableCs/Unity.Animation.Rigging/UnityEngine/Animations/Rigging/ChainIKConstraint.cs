namespace UnityEngine.Animations.Rigging;

[AddComponentMenu("Animation Rigging/Chain IK Constraint")]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.2/manual/constraints/ChainIKConstraint.html")]
public class ChainIKConstraint : RigConstraint<ChainIKConstraintJob, ChainIKConstraintData, ChainIKConstraintJobBinder`1<ChainIKConstraintData>>
{

	public ChainIKConstraint() { }

	protected virtual void OnValidate() { }

}

