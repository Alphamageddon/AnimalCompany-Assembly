namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class NoInterpMinIntParameter : VolumeParameter<Int32>
{
	public int min; //Field offset: 0x18

	public virtual int value
	{
		 get { } //Length: 8
		 set { } //Length: 20
	}

	public NoInterpMinIntParameter(int value, int min, bool overrideState = false) { }

	public virtual int get_value() { }

	public virtual void set_value(int value) { }

}

