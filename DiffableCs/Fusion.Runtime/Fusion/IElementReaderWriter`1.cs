namespace Fusion;

public interface IElementReaderWriter
{

	public int GetElementHashCode(T element) { }

	public int GetElementWordCount() { }

	public T Read(Byte* data, int index) { }

	public T ReadRef(Byte* data, int index) { }

	public void Write(Byte* data, int index, T element) { }

}

