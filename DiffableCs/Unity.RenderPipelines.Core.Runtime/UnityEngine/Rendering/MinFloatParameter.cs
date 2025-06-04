namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class MinFloatParameter : FloatParameter
{
	public float min; //Field offset: 0x18

	public virtual float value
	{
		 get { } //Length: 8
		 set { } //Length: 20
	}

	public MinFloatParameter(float value, float min, bool overrideState = false) { }

	public virtual float get_value() { }

	public virtual void set_value(float value) { }

}

