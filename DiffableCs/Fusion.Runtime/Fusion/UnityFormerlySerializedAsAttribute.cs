namespace Fusion;

[AttributeUsage(AttributeTargets::Property (128))]
[Conditional("UNITY_2020_1_OR_NEWER")]
[Conditional("UNITY_EDITOR")]
[Conditional("FUSION_UNITY")]
[UnityPropertyAttributeProxy(typeof(FormerlySerializedAsAttribute))]
public sealed class UnityFormerlySerializedAsAttribute : Attribute
{

	public UnityFormerlySerializedAsAttribute(string oldName) { }

}

