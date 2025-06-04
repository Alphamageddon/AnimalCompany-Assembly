namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class NoInterpMaxIntParameter : VolumeParameter<Int32>
{
	public int max; //Field offset: 0x18

	public virtual int value
	{
		 get { } //Length: 8
		 set { } //Length: 20
	}

	public NoInterpMaxIntParameter(int value, int max, bool overrideState = false) { }

	public virtual int get_value() { }

	public virtual void set_value(int value) { }

}

