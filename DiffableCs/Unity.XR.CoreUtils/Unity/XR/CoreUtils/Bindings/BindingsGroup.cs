namespace Unity.XR.CoreUtils.Bindings;

public class BindingsGroup
{
	private readonly List<IEventBinding> m_Bindings; //Field offset: 0x10

	public BindingsGroup() { }

	public void AddBinding(IEventBinding binding) { }

	public void Bind() { }

	public void Clear() { }

	public void ClearBinding(IEventBinding binding) { }

	public void Unbind() { }

}

