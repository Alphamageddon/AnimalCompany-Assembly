namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class NoInterpClampedIntParameter : VolumeParameter<Int32>
{
	public int min; //Field offset: 0x18
	public int max; //Field offset: 0x1C

	public virtual int value
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public NoInterpClampedIntParameter(int value, int min, int max, bool overrideState = false) { }

	public virtual int get_value() { }

	public virtual void set_value(int value) { }

}

