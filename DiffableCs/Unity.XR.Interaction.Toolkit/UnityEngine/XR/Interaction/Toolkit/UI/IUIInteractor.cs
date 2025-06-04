namespace UnityEngine.XR.Interaction.Toolkit.UI;

public interface IUIInteractor
{

	public bool TryGetUIModel(out TrackedDeviceModel model) { }

	public void UpdateUIModel(ref TrackedDeviceModel model) { }

}

