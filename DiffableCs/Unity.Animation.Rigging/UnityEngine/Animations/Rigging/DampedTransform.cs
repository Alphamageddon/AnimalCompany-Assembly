namespace UnityEngine.Animations.Rigging;

[AddComponentMenu("Animation Rigging/Damped Transform")]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.2/manual/constraints/DampedTransform.html")]
public class DampedTransform : RigConstraint<DampedTransformJob, DampedTransformData, DampedTransformJobBinder`1<DampedTransformData>>
{

	public DampedTransform() { }

	protected virtual void OnValidate() { }

}

