namespace UnityEngine.Animations.Rigging;

[AddComponentMenu("Animation Rigging/Twist Correction")]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.2/manual/constraints/TwistCorrection.html")]
public class TwistCorrection : RigConstraint<TwistCorrectionJob, TwistCorrectionData, TwistCorrectionJobBinder`1<TwistCorrectionData>>
{

	public TwistCorrection() { }

	protected virtual void OnValidate() { }

}

