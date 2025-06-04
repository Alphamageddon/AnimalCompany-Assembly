namespace UnityEngine.XR.Interaction.Toolkit;

public sealed class VignetteParameters
{
	public static class Defaults
	{
		public const float apertureSizeMax = 1; //Field offset: 0x0
		public const float featheringEffectMax = 1; //Field offset: 0x0
		public const float apertureVerticalPositionMax = 0.2; //Field offset: 0x0
		public const float apertureVerticalPositionMin = -0.2; //Field offset: 0x0
		public const float apertureSizeDefault = 0.7; //Field offset: 0x0
		public const float featheringEffectDefault = 0.2; //Field offset: 0x0
		public const float easeInTimeDefault = 0.3; //Field offset: 0x0
		public const float easeOutTimeDefault = 0.3; //Field offset: 0x0
		public const bool easeInTimeLockDefault = False; //Field offset: 0x0
		public const float easeOutDelayTimeDefault = 0; //Field offset: 0x0
		public static readonly Color vignetteColorDefault; //Field offset: 0x0
		public const float apertureVerticalPositionDefault = 0; //Field offset: 0x0
		public static readonly Color vignetteColorBlendDefault; //Field offset: 0x10
		public static readonly VignetteParameters defaultEffect; //Field offset: 0x20
		public static readonly VignetteParameters noEffect; //Field offset: 0x28

		private static Defaults() { }

	}

	[Range(0, 1)]
	[SerializeField]
	private float m_ApertureSize; //Field offset: 0x10
	[Range(0, 1)]
	[SerializeField]
	private float m_FeatheringEffect; //Field offset: 0x14
	[SerializeField]
	private float m_EaseInTime; //Field offset: 0x18
	[SerializeField]
	private float m_EaseOutTime; //Field offset: 0x1C
	[SerializeField]
	private bool m_EaseInTimeLock; //Field offset: 0x20
	[SerializeField]
	private float m_EaseOutDelayTime; //Field offset: 0x24
	[SerializeField]
	private Color m_VignetteColor; //Field offset: 0x28
	[SerializeField]
	private Color m_VignetteColorBlend; //Field offset: 0x38
	[Range(-0.2, 0.2)]
	[SerializeField]
	private float m_ApertureVerticalPosition; //Field offset: 0x48

	public float apertureSize
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float apertureVerticalPosition
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float easeInTime
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool easeInTimeLock
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float easeOutDelayTime
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float easeOutTime
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float featheringEffect
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Color vignetteColor
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public Color vignetteColorBlend
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public VignetteParameters() { }

	public void CopyFrom(VignetteParameters parameters) { }

	public float get_apertureSize() { }

	public float get_apertureVerticalPosition() { }

	public float get_easeInTime() { }

	public bool get_easeInTimeLock() { }

	public float get_easeOutDelayTime() { }

	public float get_easeOutTime() { }

	public float get_featheringEffect() { }

	public Color get_vignetteColor() { }

	public Color get_vignetteColorBlend() { }

	public void set_apertureSize(float value) { }

	public void set_apertureVerticalPosition(float value) { }

	public void set_easeInTime(float value) { }

	public void set_easeInTimeLock(bool value) { }

	public void set_easeOutDelayTime(float value) { }

	public void set_easeOutTime(float value) { }

	public void set_featheringEffect(float value) { }

	public void set_vignetteColor(Color value) { }

	public void set_vignetteColorBlend(Color value) { }

}

