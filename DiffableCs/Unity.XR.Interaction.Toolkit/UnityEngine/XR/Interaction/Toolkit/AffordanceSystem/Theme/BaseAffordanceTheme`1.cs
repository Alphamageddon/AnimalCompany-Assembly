namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme;

public abstract class BaseAffordanceTheme : IEquatable<BaseAffordanceTheme`1<T>>
{
	[SerializeField]
	[Tooltip("Curve used to evaluate the target value of the animation state according to the affordance state's transition amount value.")]
	private AnimationCurveDatumProperty m_StateAnimationCurve; //Field offset: 0x0
	[SerializeField]
	[Tooltip("List of affordance states supported by this theme. The entry index is how states are mapped to their theme data.\nDo not re-order entries.")]
	private List<AffordanceThemeData`1<T>> m_List; //Field offset: 0x0

	public AnimationCurve animationCurve
	{
		 get { } //Length: 80
	}

	protected BaseAffordanceTheme`1() { }

	public override void CopyFrom(BaseAffordanceTheme<T> other) { }

	public override bool Equals(BaseAffordanceTheme<T> other) { }

	public virtual bool Equals(object obj) { }

	public AnimationCurve get_animationCurve() { }

	public AffordanceThemeData<T> GetAffordanceThemeDataForIndex(byte stateIndex) { }

	public virtual int GetHashCode() { }

	public void SetAffordanceThemeDataList(List<AffordanceThemeData`1<T>> newList) { }

	public void SetAnimationCurve(AnimationCurve newAnimationCurve) { }

	internal void ValidateTheme() { }

}

