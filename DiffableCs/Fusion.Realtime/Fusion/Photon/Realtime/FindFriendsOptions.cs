namespace Fusion.Photon.Realtime;

internal class FindFriendsOptions
{
	public bool CreatedOnGs; //Field offset: 0x10
	public bool Visible; //Field offset: 0x11
	public bool Open; //Field offset: 0x12

	public FindFriendsOptions() { }

	internal int ToIntFlags() { }

}

