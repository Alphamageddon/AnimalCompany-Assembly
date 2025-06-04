namespace Fusion.Runtime.Unity;

[AttributeUsage(324, AllowMultiple = True)]
[Conditional("FUSION_UNITY")]
internal class UnityDummyAttribute : Attribute
{

	public UnityDummyAttribute() { }

	public UnityDummyAttribute(string str) { }

}

