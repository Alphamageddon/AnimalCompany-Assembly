namespace UnityEngine.Animations.Rigging;

[AddComponentMenu("Animation Rigging/Multi-Referential Constraint")]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.2/manual/constraints/MultiReferentialConstraint.html")]
public class MultiReferentialConstraint : RigConstraint<MultiReferentialConstraintJob, MultiReferentialConstraintData, MultiReferentialConstraintJobBinder`1<MultiReferentialConstraintData>>
{

	public MultiReferentialConstraint() { }

	protected virtual void OnValidate() { }

}

