namespace UnityEngine.Animations.Rigging;

[AddComponentMenu("Animation Rigging/Override Transform")]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.2/manual/constraints/OverrideTransform.html")]
public class OverrideTransform : RigConstraint<OverrideTransformJob, OverrideTransformData, OverrideTransformJobBinder`1<OverrideTransformData>>
{

	public OverrideTransform() { }

	protected virtual void OnValidate() { }

}

