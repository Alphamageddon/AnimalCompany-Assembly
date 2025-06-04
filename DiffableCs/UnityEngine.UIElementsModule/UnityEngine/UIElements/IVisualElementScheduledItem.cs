namespace UnityEngine.UIElements;

public interface IVisualElementScheduledItem
{

	public IVisualElementScheduledItem Every(long intervalMs) { }

	public void ExecuteLater(long delayMs) { }

	public void Pause() { }

	public void Resume() { }

	public IVisualElementScheduledItem StartingIn(long delayMs) { }

}

