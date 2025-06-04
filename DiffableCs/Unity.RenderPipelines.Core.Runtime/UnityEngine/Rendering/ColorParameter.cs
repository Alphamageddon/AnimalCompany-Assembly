namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class ColorParameter : VolumeParameter<Color>
{
	public bool hdr; //Field offset: 0x24
	public bool showAlpha; //Field offset: 0x25
	public bool showEyeDropper; //Field offset: 0x26

	public ColorParameter(Color value, bool overrideState = false) { }

	public ColorParameter(Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = false) { }

	public virtual void Interp(Color from, Color to, float t) { }

}

