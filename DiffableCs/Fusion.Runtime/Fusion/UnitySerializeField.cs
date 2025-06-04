namespace Fusion;

[AttributeUsage(AttributeTargets::Property (128))]
[Conditional("UNITY_2020_1_OR_NEWER")]
[Conditional("FUSION_UNITY")]
[Conditional("UNITY_EDITOR")]
[UnityPropertyAttributeProxy(typeof(SerializeField))]
public sealed class UnitySerializeField : Attribute
{

	public UnitySerializeField() { }

}

