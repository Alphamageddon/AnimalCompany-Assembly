namespace System.ComponentModel;

public interface IContainer : IDisposable
{

	public void Remove(IComponent component) { }

}

