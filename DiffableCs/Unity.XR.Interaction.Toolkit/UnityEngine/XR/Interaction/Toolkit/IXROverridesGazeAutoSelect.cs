namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXROverridesGazeAutoSelect
{

	public float gazeTimeToSelect
	{
		 get { } //Length: 0
	}

	public bool overrideGazeTimeToSelect
	{
		 get { } //Length: 0
	}

	public bool overrideTimeToAutoDeselectGaze
	{
		 get { } //Length: 0
	}

	public float timeToAutoDeselectGaze
	{
		 get { } //Length: 0
	}

	public float get_gazeTimeToSelect() { }

	public bool get_overrideGazeTimeToSelect() { }

	public bool get_overrideTimeToAutoDeselectGaze() { }

	public float get_timeToAutoDeselectGaze() { }

}

