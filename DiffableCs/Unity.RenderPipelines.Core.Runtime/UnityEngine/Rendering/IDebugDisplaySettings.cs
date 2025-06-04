namespace UnityEngine.Rendering;

public interface IDebugDisplaySettings : IDebugDisplaySettingsQuery
{

	public void ForEach(Action<IDebugDisplaySettingsData> onExecute) { }

	public void Reset() { }

}

