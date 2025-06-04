namespace Unity.XR.CoreUtils.Bindings;

public interface IEventBinding
{

	public bool IsBound
	{
		 get { } //Length: 0
	}

	public void Bind() { }

	public void ClearBinding() { }

	public bool get_IsBound() { }

	public void Unbind() { }

}

