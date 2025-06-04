namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class MaxFloatParameter : FloatParameter
{
	public float max; //Field offset: 0x18

	public virtual float value
	{
		 get { } //Length: 8
		 set { } //Length: 20
	}

	public MaxFloatParameter(float value, float max, bool overrideState = false) { }

	public virtual float get_value() { }

	public virtual void set_value(float value) { }

}

