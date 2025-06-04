namespace Photon.Voice.IOS;

public struct AudioSessionParameters
{
	public AudioSessionCategory Category; //Field offset: 0x0
	public AudioSessionMode Mode; //Field offset: 0x4
	public AudioSessionCategoryOption[] CategoryOptions; //Field offset: 0x8

	public int CategoryOptionsToInt() { }

	public virtual string ToString() { }

}

