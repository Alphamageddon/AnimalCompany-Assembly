namespace Oculus.Platform.Models;

public class LanguagePackInfo
{
	public readonly string EnglishName; //Field offset: 0x10
	public readonly string NativeName; //Field offset: 0x18
	public readonly string Tag; //Field offset: 0x20

	public LanguagePackInfo(IntPtr o) { }

}

