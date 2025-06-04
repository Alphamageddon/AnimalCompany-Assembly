namespace SpatialSys.ObservableState;

public sealed class ObserverDelegate : MulticastDelegate
{

	public ObserverDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(StateChangedEventArgs args, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(StateChangedEventArgs args) { }

}

