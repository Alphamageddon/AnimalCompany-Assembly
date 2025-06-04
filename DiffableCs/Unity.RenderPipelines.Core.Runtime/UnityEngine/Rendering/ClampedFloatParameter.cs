namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class ClampedFloatParameter : FloatParameter
{
	public float min; //Field offset: 0x18
	public float max; //Field offset: 0x1C

	public virtual float value
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public ClampedFloatParameter(float value, float min, float max, bool overrideState = false) { }

	public virtual float get_value() { }

	public virtual void set_value(float value) { }

}

