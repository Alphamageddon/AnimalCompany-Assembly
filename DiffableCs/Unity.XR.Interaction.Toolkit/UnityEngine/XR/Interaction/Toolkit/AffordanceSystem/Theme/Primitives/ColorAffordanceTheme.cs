namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme.Primitives;

public class ColorAffordanceTheme : BaseAffordanceTheme<Color>
{
	[Header("Color Blend Configuration")]
	[SerializeField]
	[Tooltip("- Solid: Replaces the target value directly.\n- Add: Adds initial color to target color.\n- Mix: Blends initial and target color.")]
	private ColorBlendMode m_ColorBlendMode; //Field offset: 0x20
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Value between 0 and 1 used to compute color blend modes.")]
	private float m_BlendAmount; //Field offset: 0x24

	public float blendAmount
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public ColorBlendMode colorBlendMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public ColorAffordanceTheme() { }

	public virtual void CopyFrom(BaseAffordanceTheme<Color> other) { }

	public float get_blendAmount() { }

	public ColorBlendMode get_colorBlendMode() { }

	public void set_blendAmount(float value) { }

	public void set_colorBlendMode(ColorBlendMode value) { }

}

