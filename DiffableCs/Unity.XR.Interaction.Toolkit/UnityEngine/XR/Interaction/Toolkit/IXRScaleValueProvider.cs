namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRScaleValueProvider
{

	public ScaleMode scaleMode
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float scaleValue
	{
		 get { } //Length: 0
	}

	public ScaleMode get_scaleMode() { }

	public float get_scaleValue() { }

	public void set_scaleMode(ScaleMode value) { }

}

